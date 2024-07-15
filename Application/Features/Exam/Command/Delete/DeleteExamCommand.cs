using MediatR;

namespace Application.Features.Exam.Command.Delete
{
    public class DeleteExamCommand(Guid id) : IRequest<string>
    {
        public Guid ExamId { get; set; } = id;
    }
}
