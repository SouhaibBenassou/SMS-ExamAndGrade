using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.TestResultDto;
using MediatR;

namespace Application.Features.TestResult.Queries.GetTestResultsByTestIdQuery;

public class GetTestResultsByTestIdQueryHandler: IRequestHandler<GetTestResultsByTestIdQuery,List<TestResultDto>>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public GetTestResultsByTestIdQueryHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<List<TestResultDto>> Handle(GetTestResultsByTestIdQuery request, CancellationToken cancellationToken)
    {
        List<Domain.Entities.TestResult> testResults = await _unitOfService.TestResultService.GetResultsByTest(request.TestId);
        return _mapper.Map<List<TestResultDto>>(testResults);
    }
}