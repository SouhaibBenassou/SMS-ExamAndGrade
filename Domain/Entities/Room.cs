using Domain.Enums;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Room : AuditableEntity
    {
        public int Capacity { get; set; }
        public string? RoomName { get; set; }
        public RoomType RoomType { get; set; }
        public ICollection<ExamSession>? ExamSessions { get; set; }
    }
}

