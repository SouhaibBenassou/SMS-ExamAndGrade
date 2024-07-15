using Domain.Entities;

namespace Application.IServices
{
    public interface IRoomService
    {
        Task<string> AddRoomAsync(Room room);
        Task<string> UpdateRoomAsync(Room room);
        Task<string> DeleteRoomAsync(Guid id);
        Task<List<Room>> GetListOfRoomsAsync();
        Task<Room> GetRoomByIdAsync(Guid id);

    }
}
