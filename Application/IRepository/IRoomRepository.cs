using Domain.Entities;

namespace Application.IRepository
{
    public interface IRoomRepository : IAsyncRepository<Room>
    {
        Task<IEnumerable<Room>> FindAllAsync();
        Task AddAsync(Room room);
        Task<Room> GetByIdAsync(Guid roomId);
        void Update(Room room);
        void Delete(Room room);
    }
}
