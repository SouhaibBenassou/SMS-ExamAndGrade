using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Year : AuditableEntity
    {

        public string YearName { get; set; }
        [JsonIgnore]
        public ICollection<Exam> Exams { get; set; }

    }
}
