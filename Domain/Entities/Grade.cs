
namespace Domain;

public class Grade : AuditableEntity
{
    public Guid ExamResultId { get; set; }
    public ExamResult? ExamResult { get; set; }
    public Guid TestResultsId { get; set; }
    public TestResults? TestResults { get; set; }

}
