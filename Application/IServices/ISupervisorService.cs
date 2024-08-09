using Domain.Dtos.SupervisorDto;
using Domain.Entities;


namespace Application.IServices
{
    public interface ISupervisorService
    {
        Task<string> AddSupervisorAsync(Supervisor supervisor);
        Task<string> UpdateSupervisorAsync(Supervisor supervisor);
        Task<string> DeleteSupervisorAsync(Guid id);
        Task<List<Supervisor>> GetListOfSupervisorsAsync();
        Task<SupervisorDto> GetSupervisorByIdAsync(Guid Id);
        Task<Supervisor> GetSupervisorById(Guid id);

    }
}
