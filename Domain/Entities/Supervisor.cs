using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Supervisor : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public ICollection<Exam> Exams { get; set; }
    }
}

