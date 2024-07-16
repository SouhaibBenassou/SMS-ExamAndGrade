using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Year : AuditableEntity
    {

        public string? YearName { get; set; }
        public ICollection<Exam>? Exams { get; set; }

    }
}
