using System.Linq.Expressions;
using Application;
using Domain;
using Domain.EntitiesFromOtherServices.FiliereService;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories
{
    public class TestRepository : AsyncRepository<Test>, ITestRepository
    {
        private readonly ApplicationDbContext _db;

        public TestRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }


        public async Task<Test> GetTestWithResults(Expression<Func<Test, bool>> filter = null)
        {
            IQueryable<Test> query = dbSet
                .Include(t=>t.TestResults)
                .Include(t=>t.Filiere)
                .Include(t=>t.UnitOfFormation);
            if (filter is not null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }
        public async Task<List<Test>> GetAllTestWithResults(Expression<Func<Test, bool>> filter = null)
        {
            IQueryable<Test> query = dbSet
                .Include(t=>t.TestResults)
                .Include(t=>t.Filiere)
                .Include(t=>t.UnitOfFormation);
            if (filter is not null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
        
        
    }
}
