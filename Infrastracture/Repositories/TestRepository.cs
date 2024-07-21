using Application.IRepository;
using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Repositories
{
    public class TestRepository : AsyncRepository<Test>, ITestRepository
    {
        private readonly ApplicationDbContext _db;
        public TestRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
