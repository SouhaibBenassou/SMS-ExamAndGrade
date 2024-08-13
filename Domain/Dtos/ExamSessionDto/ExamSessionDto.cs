namespace Domain.Dtos.ExamSessionDto;

public class ExamSessionDto
{
    public Guid Id  { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid RoomId { get; set; }
    public RoomDto Room { get; set; }
    public Guid SupervisorId { get; set; }
    public SupervisorDto.SupervisorDto Supervisor { get; set; }
}