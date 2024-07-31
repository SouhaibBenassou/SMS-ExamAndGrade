using Application.IRepository;
using Domain;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories
{
    public class ExamResultRepository : AsyncRepository<ExamResult>, IExamResultRepository
    {
        private readonly ApplicationDbContext _db;

        public ExamResultRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }

        public async Task<bool> CheckExam(Guid id) {
            return await _db.Set<ExamResult>().AnyAsync(r => r.ExamId == id);
        }

        public async Task<bool> CheckStagier(Guid id) {
            return await _db.Set<ExamResult>().AnyAsync(r => r.StagiaireId == id);
        }

        public async Task<ExamResult> FindStagiere(Guid Stagiereid, Guid ExamId) {
            ExamResult stagiere = await _db.Set<ExamResult>().FirstOrDefaultAsync(e => e.StagiaireId == Stagiereid && e.ExamId == ExamId);
            if (stagiere == null)
            {
                return null;
            }
            return stagiere;

        }

        public async Task<List<ExamResult>> GetExamResultByExamI(Guid id) {
            return await _db.Set<ExamResult>().Where(e => e.ExamId == id).ToListAsync();
        }
    }
}
