using Application.Interfaces;
using Application.IServices;
using AutoMapper;
using Domain.Dtos.SupervisorDto;
using Domain.Entities;

namespace Application.Services
{
    public class SupervisorService : ISupervisorService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public SupervisorService(IMapper mapper, IUnitOfWork unitOfWork) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> AddSupervisorAsync(Supervisor supervisor) {

            await _unitOfWork.SupervisorRepository.CreateAsync(supervisor);
            await _unitOfWork.CompleteAsync();
            return "Room successfully added.";


        }

        public  async Task<string> DeleteSupervisorAsync(Guid id) {
            var supervisor = await _unitOfWork.SupervisorRepository.GetAsNoTracking(r => r.Id == id);
            if (supervisor == null)
            {
                return $"Supervisor with Id : {id} not found.";
            }

            await _unitOfWork.SupervisorRepository.RemoveAsync(supervisor);
            await _unitOfWork.CompleteAsync();

            return "Supervisor successfully deleted.";
        }

        public async Task<List<Supervisor>> GetListOfSupervisorsAsync() {
            var supervisors = await _unitOfWork.SupervisorRepository.GetAllAsTracking();
            return supervisors;
        }

        public Task<SupervisorDto> GetSupervisorByIdAsync(Guid Id) {
            throw new NotImplementedException();
        }

        public async Task<string> UpdateSupervisorAsync(Supervisor supervisor) {
            var existingSupervisor = await _unitOfWork.SupervisorRepository.GetAsNoTracking(r => r.Id == supervisor.Id);
            if (existingSupervisor == null)
            {
                return $"Supervisor with Id {supervisor.Id} not found.";
            }

            existingSupervisor.FirstName = supervisor.FirstName;
            existingSupervisor.LastName = supervisor.LastName;
            existingSupervisor.Title = supervisor.Title;
            await _unitOfWork.SupervisorRepository.UpdateAsync(existingSupervisor);
            await _unitOfWork.CompleteAsync();

            return "Supervisor successfully updated.";
        }
        
        
        
        public async Task<Supervisor> GetSupervisorById(Guid id)
        {
            return await _unitOfWork.SupervisorRepository.GetAsNoTracking(s => s.Id == id);
        }
    }
}
