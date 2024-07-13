using Domain.Dtos;
using Domain.Entities;

namespace Application.IServices
{
    public interface IRoomService
    {
        Task<string> AddRoomAsync(Room room);
        Task<string> UpdateRoomAsync(Room room);
        Task<string> DeleteRoomAsync(Guid roomId);
        Task<IEnumerable<RoomDto>> GetListOfRoomsAsync();
        Task<RoomDto> GetRoomByIdAsync(Guid roomId);

    }
}
