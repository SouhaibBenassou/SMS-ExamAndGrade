using Domain.Dtos.SupervisorDto;
using Domain.Entities;


namespace Application.IServices
{
    public interface ISupervisorService
    {
        Task<string> AddSupervisorAsync(Supervisor supervisor);
        Task<string> UpdateSupervisorAsync(Supervisor supervisor);
        Task<string> DeleteSupervisorAsync(Guid id);
        Task<List<SupervisorDto>> GetListOfSupervisorsAsync();
        Task<SupervisorDto> GetSupervisorByIdAsync(Guid Id);

    }
}
