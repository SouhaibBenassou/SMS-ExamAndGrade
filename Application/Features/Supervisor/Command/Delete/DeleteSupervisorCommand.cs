using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Supervisor.Commands.Delete
{
    public class DeleteSupervisorCommand : IRequest<string>
    {
        public Guid SupervisorId { get; }

        public DeleteSupervisorCommand(Guid supervisorId)
        {
            SupervisorId = supervisorId;
        }
    }
}
