using Domain.Dtos.ResultsDto;
using MediatR;

namespace Application.Features.Results.Command.Create
{
    public class AddExamResultsCommand : IRequest<string>
    {
        public Guid ExamId { get; set; }
        public List<StagiaireNoteDetailDto> StagiaireNoteDetails { get; set; }
    }
}
