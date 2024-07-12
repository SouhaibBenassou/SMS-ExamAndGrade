using MediatR;
using System;


namespace Application.Features.Supervisor.Commands.Update
{
    public class UpdateSupervisorCommand : IRequest<Unit>
    {
        public Domain.Entities.Supervisor Supervisor { get; }

        public UpdateSupervisorCommand(Domain.Entities.Supervisor supervisor)
        {
            Supervisor = supervisor;
        }
    }
}
