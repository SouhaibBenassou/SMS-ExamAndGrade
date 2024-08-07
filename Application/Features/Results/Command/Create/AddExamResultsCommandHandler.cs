using Application.Features.Results.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Results.Command.Create
{
    public class AddExamResultsCommandHandler : IRequestHandler<AddExamResultsCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public AddExamResultsCommandHandler(IUnitOfService unitOfService, IMapper mapper) {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddExamResultsCommand request, CancellationToken cancellationToken) {
            Domain.Entities.Exam exam = await _unitOfService.ExamService.GetExamByIdAsync(request.ExamId) ?? throw new ExamNotFoundExceptions(request.ExamId);

            List<ExamResult> examResult = new();

            foreach (var StagiaireNoteDetails in request.StagiaireNoteDetails)
            {

                examResult.Add(new ExamResult
                {
                    ExamId = request.ExamId,
                    StagiaireId = StagiaireNoteDetails.StagiaireId,
                    PracticalNote = StagiaireNoteDetails.PracticalNote,
                    TheoreticalNote = StagiaireNoteDetails.TheoreticalNote,
                    IsValid = false,

                });
            }

            return await _unitOfService.ExamResultsService.AddListExamResults(examResult);
        }
    }

}