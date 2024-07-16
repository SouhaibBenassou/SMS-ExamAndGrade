namespace Domain;

public class Stagiaire : AuditableEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CIN { get; set; }
}
