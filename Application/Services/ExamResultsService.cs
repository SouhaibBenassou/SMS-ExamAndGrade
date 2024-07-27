using Application.Interfaces;
using Application.IServices;
using Domain;

namespace Application.Services
{
    public class ExamResultsService : IExamResultsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamResultsService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public Task<string> AddExamResultAsync(ExamResult examResult) {
            throw new NotImplementedException();
        }

        public Task<string> DeleteExamResultAsync(Guid id) {
            throw new NotImplementedException();
        }

        public async Task<ExamResult> GetExamResultByIdAsync(Guid id) {
            ExamResult examResult = await _unitOfWork.ExamResultRepository.GetAsTracking(r => r.Id == id);
            if (examResult == null)
            {
                return null;
            }
            return examResult;
        }

        public Task<List<ExamResult>> GetListOfExamResultsAsync() {
            throw new NotImplementedException();
        }

        public async Task<string> UpdateExamResultAsync(ExamResult examResult) {
            await _unitOfWork.ExamResultRepository.UpdateAsync(examResult);
            await _unitOfWork.CommitAsync();
            return "The Resutls has Been updated";
        }
    }
}
