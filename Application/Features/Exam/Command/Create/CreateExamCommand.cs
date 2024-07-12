using Domain;
using MediatR;

namespace Application.Features.Exam.Command.Create
{
    public class CreateExamCommand : IRequest<string>
    {
        public TimeOnly StartExam { get; set; }
        public DateOnly Date { get; set; }
        public Guid IdYear { get; set; }
        public VariantType ExamType { get; set; }
        public Guid SessionsExamId { get; set; }
        public TimeOnly EndExam { get; set; }
        public StatusType Status { get; set; }
        public Guid SupervisorId { get; set; }
    }
}
