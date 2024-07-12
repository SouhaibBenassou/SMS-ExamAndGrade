using Application.IRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Supervisor.Queries
{
    public class GetSupervisorByIdHandler : IRequestHandler<GetSupervisorByIdQuery, Domain.Entities.Supervisor>

    {
        private readonly ISupervisorRepository _supervisorRepository;

        public GetSupervisorByIdHandler(ISupervisorRepository supervisorRepository)
        {
            _supervisorRepository = supervisorRepository;
        }

        public async Task<Domain.Entities.Supervisor> Handle(GetSupervisorByIdQuery request, CancellationToken cancellationToken)
        {
            return await _supervisorRepository.GetAsNoTracking(s => s.Id == request.SupervisorId);
        }
    }
}
