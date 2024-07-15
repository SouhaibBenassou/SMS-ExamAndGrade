using Domain.Entities;

namespace Application.IServices
{
    public interface IExamService
    {
        Task<string> AddExamAsync(Exam exam);
        Task<string> UpdateExamAsync(Exam exam);
        Task<string> DeleteExamAsync(Guid id);
        Task<List<Exam>> GetListOfExamWithEntityAsync();
        Task<Room> GetExamByIdAsync(Guid id);


    }
}
