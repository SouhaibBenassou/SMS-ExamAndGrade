using Application;
using Domain;
using Infrastructure.Data;

namespace Infrastracture.Repositories
{
    public class TestRepository : AsyncRepository<Test>, ITestRepository
    {
        private readonly ApplicationDbContext _db;

        public TestRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }


    }
}
