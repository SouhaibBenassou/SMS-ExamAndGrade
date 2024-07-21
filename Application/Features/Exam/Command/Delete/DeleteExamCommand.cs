using MediatR;

namespace Application.Features.Exam.Command.Delete
{
    public class DeleteTestCommand(Guid id) : IRequest<string>
    {
        public Guid ExamId { get; set; } = id;
    }
}
