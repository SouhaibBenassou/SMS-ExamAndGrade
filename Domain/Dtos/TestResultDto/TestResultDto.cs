namespace Domain.Dtos.TestResultDto;

public class TestResultDto
{
    public Guid? Id { get; set; }
    public Guid? StagiaireId { get; set; }
    public double? Note { get; set; }
    public bool? IsValid { get; set; }
    public DateOnly? DateValidation { get; set; }
}