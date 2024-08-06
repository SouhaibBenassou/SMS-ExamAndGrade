namespace Domain.Entities
{
    public class ExamAttendance : AuditableEntity
    {
        public Guid? ExamId { get; set; }
        public Exam? Exam { get; set; }
        public bool? Attendance { get; set; }
        public Guid? StagiaireId { get; set; }
    }
}
