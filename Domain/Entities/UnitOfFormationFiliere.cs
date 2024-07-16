namespace Domain;

public class UnitOfFormationFiliere
{
    public Guid FiliereId { get; set; }
    public Filiere? Filiere { get; set; }
    public Guid UnitFormationId { get; set; }
    public UnitOfFormation? UnitOfFormation { get; set; }

}
