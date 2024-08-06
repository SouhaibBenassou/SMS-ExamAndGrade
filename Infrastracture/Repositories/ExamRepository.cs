using Application.IRepository;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories
{
    public class ExamRepository : AsyncRepository<Exam>, IExamRepository
    {
        private readonly ApplicationDbContext _db;
        public ExamRepository(ApplicationDbContext context) : base(context) {
            _db = context;
        }

        public async Task<List<Exam>> GetAllWithRelatedEntities() {
            return await _db.Exams
        .AsNoTracking()
        .Include(e => e.Room)
        .Include(e => e.Supervisor)
        .Include(e => e.VariantsExams)
        .Include(e => e.ExamResults)
        .ToListAsync();
        }
    }
}
