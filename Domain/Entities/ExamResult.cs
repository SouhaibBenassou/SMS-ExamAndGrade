using Domain.Entities;

namespace Domain;

public class ExamResult : AuditableEntity
{

    public Guid? ExamId { get; set; }
    public Exam? Exam { get; set; }
    public Guid? StagiaireId { get; set; }
    public double? PracticalNote { get; set; }
    public double? TheoreticalNote { get; set; }
    public bool? IsValid { get; set; }
    public DateOnly? DateValidation { get; set; }

}
