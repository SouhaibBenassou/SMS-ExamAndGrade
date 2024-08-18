using Domain.Dtos.FiliereDto;
using Domain.Dtos.UnitOfFormationDto;

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
        public FiliereMinimaleDto Filiere { get; set; }
        public UnitOfFormationMinimaleDto? UnitOfFormation { get; set; }
        public ICollection<VariantsExamDto>? VariantsExams { get; set; }
        public ExamSessionDto.ExamSessionDto ExamSession { get; set; }
    }
}
