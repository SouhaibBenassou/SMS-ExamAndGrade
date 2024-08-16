using Domain.Enums;

namespace Domain.EntitiesFromOtherServices;

public class Trainee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? UniqueIdentifier { get; set; }
    public Guid IdFiliere { get; set; }
    public Guid? IdGroup { get; set; }
    public Group? Group { get; set; }
    public AnneeScolaire? AnneeScolaire { get; set; }
}