using Application.Interfaces;
using Application.IServices;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Services
{
    public class VariantsExamService : IVariantsExamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VariantsExamService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> AddVariantsExamAsync(VariantsExamDto variantsExamsDto)
        {
            var variantsExams = _mapper.Map<VariantsExams>(variantsExamsDto);
            await _unitOfWork.VariantsExamRepository.CreateAsync(variantsExams);
            await _unitOfWork.CompleteAsync();
            return "Variants exam successfully added.";
        }

        public async Task<List<VariantsExams>> GetAllVariantsExamsAsync()
        {
            var variantsExam = await _unitOfWork.VariantsExamRepository.GetAllAsNoTracking();
            return variantsExam;
        }
        public async Task<string> UpdateVariantsExamAsync(VariantsExamDto variantsExamsDto)
        {
            var variantsExams = _mapper.Map<VariantsExams>(variantsExamsDto);
            var existingVariantsExam = await _unitOfWork.VariantsExamRepository.GetAsNoTracking(v => v.Id == variantsExams.Id);
            if (existingVariantsExam == null)
            {
                return  $"VariantsExam with Id {variantsExamsDto.Id} not found."; ;
            }

            existingVariantsExam.Description = variantsExams.Description;
            existingVariantsExam.ExamId = variantsExams.ExamId;
            existingVariantsExam.Id = variantsExams.Id;
            existingVariantsExam.TrainerId = variantsExams.TrainerId;
            existingVariantsExam.VariantName = variantsExams.VariantName;
            existingVariantsExam.VariantType = variantsExams.VariantType;
            existingVariantsExam.ExamStatement = variantsExams.ExamStatement;
            existingVariantsExam.ExamCorrection = variantsExams.ExamCorrection;
            existingVariantsExam.IsValid = variantsExams.IsValid;

            await _unitOfWork.VariantsExamRepository.UpdateAsync(existingVariantsExam);
            await _unitOfWork.CompleteAsync();

            var Result = _mapper.Map<VariantsExamDto>(existingVariantsExam);
            return "Variants exam successfully updated.";
        }

        public async Task<VariantsExams> GetVariantsExamAsync(Guid id)
        {
            var variantsExam = await _unitOfWork.VariantsExamRepository.GetAsNoTracking(v => v.Id == id);
            if (variantsExam == null)
            {
                return null;
            }
            return variantsExam;
        }

        public async Task<string> DeleteVariantsExamAsync(Guid id)
        {
            var variantsExam = await _unitOfWork.VariantsExamRepository.GetAsNoTracking(v => v.Id == id);
            if (variantsExam == null)
            {
                return $"Variants exam with Id : {id} not found.";
            }

            await _unitOfWork.VariantsExamRepository.RemoveAsync(variantsExam);
            await _unitOfWork.CompleteAsync();

            return "Variants exam successfully deleted.";
        }
        

    }
}
