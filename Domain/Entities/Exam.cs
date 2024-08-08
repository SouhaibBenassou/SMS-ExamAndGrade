namespace Domain.Entities
{

    public class Exam : AuditableEntity
    {

        public string? ExamDate { get; set; }
        public string? Duration { get; set; }
        public string? StartTime { get; set; }
        public ExamType? ExamType { get; set; }
        public Guid? YearId { get; set; }
        public YearType? YearType { get; set; }
        public Guid? FiliereId { get; set; }
        public Guid? UnitOfFormationId { get; set; }
        public Guid? SupervisorId { get; set; }
        public Supervisor? Supervisor { get; set; }
        public ICollection<VariantsExams>? VariantsExams { get; set; }
        public ICollection<ExamAttendance>? ExamAttendances { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }
        
        public ExamSession ExamSession { get; set; }
    }
}

