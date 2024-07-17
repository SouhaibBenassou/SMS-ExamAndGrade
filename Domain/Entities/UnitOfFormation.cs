using Domain.Entities;


namespace Domain;

public class UnitOfFormation : AuditableEntity
{
    public Guid? FiliereId { get; set; }
    public Filiere? Filiere { get; set; }
    public string? Name { get; set; }
    public SemesterType? SemesterType { get; set; }
    public float? NoteExam { get; set; }
    public ICollection<UnitOfFormationFiliere>? UnitOfFormationFilieres { get; set; }
    public ICollection<Exam>? Exams { get; set; }

}