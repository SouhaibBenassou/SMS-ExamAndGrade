namespace Domain.Entities
{
    public class ExamAttendance : AuditableEntity
    {
        public Guid IdExam { get; set; }
        public bool Attendance { get; set; }
        public Guid IdTrainee { get; set; }
    }
}
