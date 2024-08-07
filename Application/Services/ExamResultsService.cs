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

        public async Task<string> AddListExamResults(List<ExamResult> examResult) {
            await _unitOfWork.ExamResultRepository.CreateRangeAsync(examResult);
            await _unitOfWork.CompleteAsync();
            return "ExamResults has been add successfuly";
        }

        public async Task<ExamResult> FindStagiere(Guid CheckStagiereid, Guid CheckExamId) {
            ExamResult examResult = await _unitOfWork.ExamResultRepository.FindStagiere(CheckStagiereid, CheckExamId);
            return examResult;
        }

        public async Task<ExamResult> FindStagiereAsync(Guid stagiaireId, Guid examId) {
            return await _unitOfWork.ExamResultRepository.FindStagiere(stagiaireId, examId);
        }

        public async Task<List<ExamResult>> GetListExamResultByIdAsync(Guid id) {
            List<ExamResult> examResult = await _unitOfWork.ExamResultRepository.GetExamResultByExamI(id);
            return examResult;
        }

        public async Task<string> UpdateStagiaireNotes(ExamResult examResult) {
            await _unitOfWork.ExamResultRepository.UpdateAsync(examResult);
            await _unitOfWork.CompleteAsync();
            return "The Resutls has Been updated";
        }
    }
}
