using Application.IRepository;
using Domain.Entities;
using Infrastracture.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class RoomRepository : AsyncRepository<Room>, IRoomRepository
    {
        private readonly ApplicationDbContext _db;

        public RoomRepository(ApplicationDbContext db) : base(db) {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

    }
}
