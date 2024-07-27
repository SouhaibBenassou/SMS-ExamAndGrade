using MediatR;

namespace Application.Features.Results.Command.update
{
    public class UpdateExamResultsCommand(Guid id) : IRequest<string>
    {
        public Guid ExamResutlId { get; set; } = id;
        public double? PracticalNote { get; set; }
        public double? TheoreticalNote { get; set; }
    }
}
