using Domain.Dtos;
using MediatR;



namespace Application.Features.Supervisor.command.Create
{
    public class CreateSupervisorCommand : IRequest<Domain.Entities.Supervisor>
    {
        public SupervisorDto SupervisorDto { get; }

        public CreateSupervisorCommand(SupervisorDto supervisorDto)
        {
            SupervisorDto = supervisorDto;
        }
    }
}