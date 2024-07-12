using Domain.Enums;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Room : AuditableEntity
    {
        public int Capacity { get; set; }
        public string RoomName { get; set; }
        public RoomType RoomType { get; set; }
        [JsonIgnore]
        public ICollection<Exam> Exams { get; set; }
    }
}

