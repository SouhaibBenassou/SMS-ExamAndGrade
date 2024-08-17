namespace Domain;

public class TestDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? TestStatement { get; set; }
    public string? TestCorrection { get; set; }
    public Guid TrainerId { get; set; }
    public Guid UnitOfFormationId { get; set; }
    public Guid FiliereId { get; set; }

}
