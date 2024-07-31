using Domain.Dtos.ResultsDto;
using MediatR;

namespace Application.Features.Results.Command.update
{
    public class UpdateExamResultsCommand : IRequest<string>
    {
        public Guid ExamId { get; set; }
        public List<StagiaireNoteDetailDto> StagiaireNoteDetails { get; set; }
    }
}
