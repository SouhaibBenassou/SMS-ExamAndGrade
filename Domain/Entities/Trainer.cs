using Domain.Entities;

namespace Domain;

public class Trainer : AuditableEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public ICollection<VariantsExams>? VariantsExams { get; set; }
    public ICollection<Test>? Tests { get; set; }
}
