using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Supervisor.Queries
{
    public class GetSupervisorByIdQuery : IRequest<Domain.Entities.Supervisor>
    {
        public Guid SupervisorId { get; }

        public GetSupervisorByIdQuery(Guid supervisorId)
        {
            SupervisorId = supervisorId;
        }
    }
}
