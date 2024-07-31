using Domain;

namespace Application.IRepository
{
    public interface IExamResultRepository : IAsyncRepository<ExamResult>
    {
        Task<bool> CheckExam(Guid id);
        Task<bool> CheckStagier(Guid id);
        Task<ExamResult> FindStagiere(Guid Stagiereid, Guid ExamId);
        Task<List<ExamResult>> GetExamResultByExamI(Guid id);
    }
}
