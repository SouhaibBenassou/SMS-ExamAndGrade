using Domain.Entities;


namespace Domain;

public class UnitOfFormation : AuditableEntity
{
    public Guid? FiliereId { get; set; }
    public Filiere? Filiere { get; set; }
    public int? Confusion { get; set; }
    public string? Name { get; set; }
    public SemesterType? SemesterType { get; set; }
    public ICollection<UnitOfFormationFiliere>? UnitOfFormationFilieres { get; set; }
    public ICollection<Exam>? Exams { get; set; }
    public ICollection<Test>? Tests { get; set; }

}