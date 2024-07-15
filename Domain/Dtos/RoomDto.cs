using Domain.Enums;

namespace Domain.Dtos
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public string RoomName { get; set; }
    }
}
