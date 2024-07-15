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

        public Task<string> DeleteSupervisorAsync(Guid id) {
            throw new NotImplementedException();
        }

        public Task<List<SupervisorDto>> GetListOfSupervisorsAsync() {
            throw new NotImplementedException();
        }

        public Task<SupervisorDto> GetSupervisorByIdAsync(Guid Id) {
            throw new NotImplementedException();
        }

        public Task<string> UpdateSupervisorAsync(Supervisor supervisor) {
            throw new NotImplementedException();
        }
    }
}
