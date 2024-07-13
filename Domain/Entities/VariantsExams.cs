using Domain.Enums;

namespace Domain.Entities
{
    public class VariantsExams : AuditableEntity
    {
        public Guid IdExam { get; set; }
        public string Description { get; set; }
        public VariantType Variant { get; set; }
        public string VariantName { get; set; }
        public string Answers { get; set; }



    }
}
