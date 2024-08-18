namespace Domain.EntitiesFromOtherServices.FiliereService;

public class Formateur : FiliereBaseEntity
{
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    public string? Email { get; set; }
    public string? Telephone { get; set; }
    public string? Type { get; set; }
    public string? Specialisation { get; set; }
    public string? Statut { get; set; }
}