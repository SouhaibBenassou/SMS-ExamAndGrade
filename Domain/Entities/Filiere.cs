using Domain.Entities;
using System.Text.Json.Serialization;

namespace Domain;

public class Filiere : AuditableEntity
{
    public string FiliereName { get; set; }
    [JsonIgnore]
    public ICollection<Exam> Exams { get; set; }

}
