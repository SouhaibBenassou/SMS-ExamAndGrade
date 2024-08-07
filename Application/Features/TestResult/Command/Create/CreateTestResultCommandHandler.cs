using System.Data;
using Application.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain;
using Domain.Dtos.TestDtos;
using Domain.Dtos.TestResultDto;
using MediatR;

namespace Application.Features.TestResult.Command.Create;

public class CreateTestResultCommandHandler : IRequestHandler<CreateTestResultCommand,TestWithListResultsDto>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public CreateTestResultCommandHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<TestWithListResultsDto> Handle(CreateTestResultCommand request, CancellationToken cancellationToken)
    {
        Test test =await _unitOfService.TestService.GetTestByIdWithResults(request.TestId);
        if (test is null)
        {
            throw new TestNotFoundException();
        }

        List<Domain.Entities.TestResult> testResults = new List<Domain.Entities.TestResult>();
        List<Guid> idsStagieres = new List<Guid>();
        foreach (StagiaireTestNoteDetailDto s in request.StagiaireTestNoteDetails)
        {
            if (idsStagieres.Contains(s.StagiaireId))
            {
                throw new DuplicatedIdStagiereInListException(s.StagiaireId);
            }
            idsStagieres.Add(s.StagiaireId);
            await _unitOfService.StagiereNoteService.CheckIfStagiereHaveNoteInTest(s.StagiaireId, request.TestId);
            testResults.Add(new Domain.Entities.TestResult
            {
                Id = default,
                CreatedAt = DateTime.Now,
                TestId = request.TestId,
                Test = test,
                StagiaireId = s.StagiaireId,
                Note = s.Note,
            });
        }
        
        await _unitOfService.TestResultService.AddRangeTestResult(testResults);
        Test testFinal = await _unitOfService.TestService.GetTestByIdWithResults(request.TestId);
        return _mapper.Map<TestWithListResultsDto>(testFinal);
    }
}