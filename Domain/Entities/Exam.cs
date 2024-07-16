namespace Domain.Entities
{

    public class Exam : AuditableEntity
    {

        public DateOnly? ExamDate { get; set; }
        public TimeOnly? Duration { get; set; }
        public TimeOnly? StartTime { get; set; }
        public ExamType? ExamType { get; set; }
        public Guid? YearId { get; set; }
        public Year? Year { get; set; }
        public Guid? SemesterId { get; set; }
        public YearType? YearType { get; set; }
        public Guid? FiliereId { get; set; }
        public Filiere? Filiere { get; set; }
        public Guid? UnitOfFormationId { get; set; }
        public UnitOfFormation? UnitOfFormation { get; set; }
        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }
        public Guid? SupervisorId { get; set; }
        public Supervisor? Supervisor { get; set; }
        public ICollection<VariantsExams>? VariantsExams { get; set; }
        public ICollection<ExamAttendance>? ExamAttendances { get; set; } // Add this line
        public ICollection<ExamResult>? ExamResults { get; set; }
    }
}
