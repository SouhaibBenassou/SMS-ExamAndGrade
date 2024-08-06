using System.Linq.Expressions;
using Application;
using Domain;
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
            IQueryable<Test> query = dbSet.Include(t=>t.TestResults);
            if (filter is not null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }
        
        
        
    }
}
