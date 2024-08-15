using Domain.Enums;

namespace Domain.EntitiesFromOtherServices;

public class Group
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid IdFiliere { get; set; }
    public int Capacity { get; set; }
}