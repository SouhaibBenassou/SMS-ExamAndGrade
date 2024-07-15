using MediatR;

namespace Application.Features.Exam.Command.Create
{
    public class CreateExamCommand : IRequest<string>
    {
        public DateTime ExamDate { get; set; }
        public DateTime Duration { get; set; }
        public DateTime StartTime { get; set; }
        public Guid YearId { get; set; }
        public Guid SemesterId { get; set; }
        public Guid YearOfStudyId { get; set; }
        public Guid FiliereId { get; set; }
        public Guid UnitOfFormationId { get; set; }
        public Guid RoomId { get; set; }
        public Guid SupervisorId { get; set; }

    }
}
