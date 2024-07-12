using Domain.Entities;
using System.Text.Json.Serialization;

namespace Domain;

public class UnitOfFormation : AuditableEntity
{

    public string UnitName { get; set; }
    [JsonIgnore]
    public ICollection<Exam> Exams { get; set; }

}