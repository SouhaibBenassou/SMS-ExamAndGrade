namespace Domain.Entities
{

    public class Exam : AuditableEntity
    {

        public DateTime ExamDate { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan StartTime { get; set; }

        public Guid YearId { get; set; }
        public Year Year { get; set; }

        public Guid SemesterId { get; set; }
        public Semester Semester { get; set; }

        public Guid YearOfStudyId { get; set; }
        public YearOfStudy YearOfStudy { get; set; }

        public Guid FiliereId { get; set; }
        public Filiere Filiere { get; set; }

        public Guid UnitOfFormationId { get; set; }
        public UnitOfFormation UnitOfFormation { get; set; }

        public Guid RoomId { get; set; }
        public Room Room { get; set; }

        public Guid SupervisorId { get; set; }
        public Supervisor Supervisor { get; set; }
    }
}
