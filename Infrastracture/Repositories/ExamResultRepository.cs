using Application.IRepository;
using Domain;
using Infrastructure.Data;

namespace Infrastracture.Repositories
{
    public class ExamResultRepository : AsyncRepository<ExamResult>, IExamResultRepository
    {
        private readonly ApplicationDbContext _db;

        public ExamResultRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }
    }
}
