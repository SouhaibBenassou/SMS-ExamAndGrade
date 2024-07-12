using Application.Interfaces;
using Application.IRepository;
using Application.IServices;
using AutoMapper;
using Domain.Entities;


namespace Application.Services
{
    public class SupervisorService : ISupervisorService
    {
        private readonly ISupervisorRepository _supervisorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public SupervisorService(ISupervisorRepository supervisorRepository, IUnitOfWork unitOfWork)
        {
            _supervisorRepository = supervisorRepository;
            _unitOfWork = unitOfWork;
        }

       
        public async Task<List<Supervisor>> GetAllSupervisorsAsync()
        {
            return await _supervisorRepository.GetAllAsNoTracking();
        }
      


       
    }
}
