using Domain;

namespace Application.IServices
{
    public interface IExamResultsService
    {
        Task<string> AddExamResultAsync(ExamResult examResult);
        Task<string> UpdateExamResultAsync(ExamResult examResult);
        Task<string> DeleteExamResultAsync(Guid id);
        Task<List<ExamResult>> GetListOfExamResultsAsync();
        Task<ExamResult> GetExamResultByIdAsync(Guid id);
    }
}
