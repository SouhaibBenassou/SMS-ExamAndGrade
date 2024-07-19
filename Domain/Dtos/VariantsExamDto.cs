using Domain.Enums;

namespace Domain.Dtos
{
    public class VariantsExamDto
    {
        public Guid Id { get; set; }
        public Guid? ExamId { get; set; }
        public string? Description { get; set; }
        public string? VariantName { get; set; }
        public string? ExamStatement { get; set; }
        public string? ExamCorrection { get; set; }
        public VariantType? VariantType { get; set; }
        public int? NoteMax { get; set; }
        public bool IsValid { get; set; }
        public Guid? TrainerId { get; set; }
    }
}
