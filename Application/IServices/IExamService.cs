using Domain.Entities;

namespace Application.IServices
{
    public interface IExamService
    {
        Task<string> AddRoomAsync(Exam exam);
        Task<string> UpdateRoomAsync(Exam exam);
        Task<string> DeleteRoomAsync(Guid id);
        Task<List<Exam>> GetListOfExamWithEntityAsync();
        Task<Room> GetRoomByIdAsync(Guid id);


    }
}
