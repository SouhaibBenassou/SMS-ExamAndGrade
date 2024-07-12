using Domain.Entities;

namespace Domain;

public class Sessions : AuditableEntity
{
    public Guid IdRoom { get; set; }
    public Room Room { get; set; }
    public TimeOnly Starts { get; set; }
    public TimeOnly Ends { get; set; }
    public Exam Exam { get; set; }
    public Guid IdSupervisor { get; set; }
    public Supervisor Supervisor { get; set; }
}
