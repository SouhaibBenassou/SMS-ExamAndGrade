namespace Domain.Entities;

public class ExamSession : AuditableEntity
{
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid RoomId { get; set; }
    public Room Room { get; set; }
    public Guid ExamId { get; set; }
    public Exam Exam { get; set; }
    public Guid SupervisorId { get; set; }
    public Supervisor Supervisor { get; set; }
}