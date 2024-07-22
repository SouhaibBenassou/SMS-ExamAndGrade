using MediatR;

namespace Application;

public class AddTestCommand : IRequest<string>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? TestStatement { get; set; }
    public string? TestCorrection { get; set; }
    public double? Note { get; set; }
    public Guid TrainerId { get; set; }
    public Guid UnitOfFormationId { get; set; }
}
