using Application.Interfaces;
using Application.IServices;
using Domain.Entities;

namespace Application.Services
{
    public class IndividualWorkUOFService : IIndividualWorkUOFService
    {
        public readonly IUnitOfWork _unitOfWork;

        public IndividualWorkUOFService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public async Task<IndividualWorkUOF> CreateIndividualWorkUOF(IndividualWorkUOF individualWorkUOF) {
            await _unitOfWork.IndividualWorkUOFRepository.CreateAsync(individualWorkUOF);
            await _unitOfWork.CommitAsync();
            return individualWorkUOF;


        }
        public async Task<List<IndividualWorkUOF>> GetAllIndividualWorkUOFs() {
            return await _unitOfWork.IndividualWorkUOFRepository.GetAllAsNoTracking();
        }

        public async Task<IndividualWorkUOF> GetIndividualWorkUOFByID(Guid id) {
            return await _unitOfWork.IndividualWorkUOFRepository.GetAsNoTracking(i => i.Id == id);
        }

        public async Task<IndividualWorkUOF> UpdateIndividualWorkUOF(IndividualWorkUOF individualWorkUOF) {
            await _unitOfWork.IndividualWorkUOFRepository.UpdateAsync(individualWorkUOF);
            await _unitOfWork.CommitAsync();
            return individualWorkUOF;
        }

    }
}
