using Domain;
using MediatR;

namespace Application.Features.Exam.Command.Create
{
    public class CreateExamCommand : IRequest<string>
    {
        public string? ExamDate { get; set; }
        public string Duration { get; set; }
        public DateTime StartTime { get; set; }
        public ExamType? ExamType { get; set; }
        public Guid? YearId { get; set; }
        public YearType? YearType { get; set; }
        public Guid? FiliereId { get; set; }
        public Guid? UnitOfFormationId { get; set; }
        public Guid RoomId { get; set; }
        public Guid SupervisorId { get; set; }
    }
}

