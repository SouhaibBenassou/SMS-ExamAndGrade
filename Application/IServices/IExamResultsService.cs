using Domain;

namespace Application.IServices
{
    public interface IExamResultsService
    {

        Task<List<ExamResult>> GetListExamResultByIdAsync(Guid id);
        Task<string> UpdateStagiaireNotes(ExamResult examResult);
        Task<ExamResult> FindStagiere(Guid CheckStagiereid, Guid CheckExamId);
        Task<ExamResult> FindStagiereAsync(Guid stagiaireId, Guid examId);
    }
}
