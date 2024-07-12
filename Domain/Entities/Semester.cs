using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Semester : AuditableEntity
    {
        public string SemesterName { get; set; }
        [JsonIgnore]
        public ICollection<Exam> Exams { get; set; }
    }
}
