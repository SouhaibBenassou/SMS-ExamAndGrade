using Domain.Entities;
using System.Text.Json.Serialization;

namespace Domain;

public class UnitOfFormation : AuditableEntity
{

    public string Name { get; set; }
    public SemesterType? SemesterType { get; set; }
    public float? NoteExam { get; set; }
    public ICollection<UnitOfFormationFiliere> UnitOfFormationFilieres { get; set; }
    public ICollection<Exam> Exams { get; set; }

}