namespace Domain.Dtos.ExamDto
{
    public class GetListExamDto
    {
        public Guid Id { get; set; }
        public string? ExamDate { get; set; }
        public string? Duration { get; set; }
        public DateTime? StartTime { get; set; }
        public ExamType? ExamType { get; set; }
        public YearType? YearType { get; set; }
        public Guid? YearId { get; set; }
        public Guid? FiliereId { get; set; }
        public Guid? UnitOfFormationId { get; set; }
        public ICollection<VariantsExamDto>? VariantsExams { get; set; }
        public ExamSessionDto.ExamSessionDto ExamSession { get; set; }
    }
}
