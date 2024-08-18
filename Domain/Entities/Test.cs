
using Domain.Entities;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Domain;

public class Test : AuditableEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? TestStatement { get; set; }
    public string? TestCorrection { get; set; }
    public double? Note { get; set; }
    public Guid? FiliereId { get; set; }
    public Filiere? Filiere { get; set; }
    public Guid TrainerId { get; set; }
    public Guid UnitOfFormationId { get; set; }
    public UnitOfFormation? UnitOfFormation { get; set; }

    public ICollection<TestResult>? TestResults { get; set; }

}
