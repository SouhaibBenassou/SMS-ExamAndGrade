using Application.Interfaces;
using Application.IServices;
using Domain.Entities;

namespace Application.Services
{
    public class ExamService : IExamService
    {
        private readonly IUnitOfWork _unitOfWork;
        Task<string> IExamService.AddRoomAsync(Exam exam) {
            throw new NotImplementedException();
        }

        Task<string> IExamService.DeleteRoomAsync(Guid id) {
            throw new NotImplementedException();
        }

        public async Task<List<Exam>> GetListOfExamWithEntityAsync() {

            return await _unitOfWork.ExamRepository.GetAllWithRelatedEntities();
        }

        Task<Room> IExamService.GetRoomByIdAsync(Guid id) {
            throw new NotImplementedException();
        }

        Task<string> IExamService.UpdateRoomAsync(Exam exam) {
            throw new NotImplementedException();
        }
    }
}
