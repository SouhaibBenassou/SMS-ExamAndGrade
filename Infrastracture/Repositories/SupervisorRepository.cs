using Application.IRepository;
using Domain.Entities;
using Infrastructure.Data;


namespace Infrastracture.Repositories
{
    public class SupervisorRepository : AsyncRepository<Supervisor>, ISupervisorRepository
    {
        private readonly ApplicationDbContext _db;

        public SupervisorRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }
    }
}
