using Application.IRepository;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastracture.Repositories
{
    public class IndividualWorkUOFRepository : AsyncRepository<IndividualWorkUOF>, IIndividualWorkUOFRepository
    {
        private readonly ApplicationDbContext _db;

        public IndividualWorkUOFRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }
    }
}
