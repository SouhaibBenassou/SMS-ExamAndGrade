using Application.Interfaces;
using Application.IServices;
using Domain.Entities;

namespace Application.Services
{

    public class ExamService : IExamService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> AddExamAsync(Exam exam)
        {
            await _unitOfWork.ExamRepository.CreateAsync(exam);
            await _unitOfWork.CompleteAsync();
            return "Exam successfully added.";
        }

        public async Task<string> DeleteExamAsync(Guid id)
        {
            var exam = await _unitOfWork.ExamRepository.GetAsNoTracking(r => r.Id == id);
            if (exam == null)
            {
                return $"Exam with Id : {id} not found.";
            }

            await _unitOfWork.ExamRepository.RemoveAsync(exam);
            await _unitOfWork.CompleteAsync();

            return "Exam successfully deleted.";
        }

        public async Task<List<Exam>> GetListOfExamWithEntityAsync()
        {

            return await _unitOfWork.ExamRepository.GetAllWithRelatedEntities();
        }



        Task<string> IExamService.UpdateExamAsync(Exam exam)
        {
            throw new NotImplementedException();
        }

        public async Task<Exam> GetExamByIdAsync(Guid id)
        {
            Exam exam = await _unitOfWork.ExamRepository.GetAsNoTracking(r => r.Id == id);

            if (exam == null)
            {
                return null;
            }
            return exam;

        }
    }
}
