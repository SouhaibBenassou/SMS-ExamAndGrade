namespace Domain;

public class Grade : AuditableEntity
{
    public Guid ExamId { get; set; }
    public Guid StagiaireId { get; set; }
    public Guid? TestId { get; set; }

}
