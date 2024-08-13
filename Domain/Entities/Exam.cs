namespace Domain.Entities
{

    public class Exam : AuditableEntity
    {
        public string? ExamDate { get; set; }
        //01:30:45
        public string? Duration { get; set; }
        public DateTime? StartTime { get; set; }
        public ExamType? ExamType { get; set; }
        public Guid? YearId { get; set; }
        public YearType? YearType { get; set; }
        public Guid? FiliereId { get; set; }
        public Guid? UnitOfFormationId { get; set; }
        public ICollection<VariantsExams>? VariantsExams { get; set; }
        public ICollection<ExamAttendance>? ExamAttendances { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }
        public ExamSession ExamSession { get; set; }
    }
}

