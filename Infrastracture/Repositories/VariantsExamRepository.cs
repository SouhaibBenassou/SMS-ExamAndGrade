using Application.IRepository;
using Domain.Entities;
using Infrastracture.Repositories;
using Infrastructure.Data;

namespace Infrastracture.Repositories
{
    public class VariantsExamRepository : AsyncRepository<VariantsExams>, IVariantsExamRepository
    {
        private readonly ApplicationDbContext _db;

        public VariantsExamRepository(ApplicationDbContext db) : base(db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
    }

}
