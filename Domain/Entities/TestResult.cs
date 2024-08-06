namespace Domain.Entities;

public class TestResult : AuditableEntity
{
    public Guid? TestId { get; set; }
    public Test? Test { get; set; }
    public Guid? StagiaireId { get; set; }
    public double? Note { get; set; }
    public bool? IsValid { get; set; }
    public DateOnly? DateValidation { get; set; }

}
