using MediatR;
using Domain.Dtos.SupervisorDto;



namespace Application.Features.Supervisor.command.Create
{
    public class CreateSupervisorCommand : IRequest<Domain.Entities.Supervisor>
    {
        public CreateSupervisorDto SupervisorDto { get; }

        public CreateSupervisorCommand(CreateSupervisorDto supervisorDto)
        {
            SupervisorDto = supervisorDto;
        }
    }
}