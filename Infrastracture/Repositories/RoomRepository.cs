using Application.IRepository;
using Domain.Entities;
using Infrastracture.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RoomRepository : AsyncRepository<Room>, IRoomRepository
    {
        private readonly ApplicationDbContext _db;

        public RoomRepository(ApplicationDbContext db) : base(db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async Task AddAsync(Room room)
        {
            await _db.Rooms.AddAsync(room);
        }

        public async Task<IEnumerable<Room>> FindAllAsync()
        {
            return await _db.Rooms.ToListAsync();
        }

        public async Task<Room> GetByIdAsync(Guid roomId)
        {
            return await _db.Rooms.FindAsync(roomId);
        }

        public void Update(Room room)
        {
            _db.Rooms.Update(room);
        }

        public void Delete(Room room)
        {
            _db.Rooms.Remove(room);
        }
    }
}
