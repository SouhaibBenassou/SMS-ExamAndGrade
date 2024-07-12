using Application.Interfaces;
using MediatR;


namespace Application.Features.Supervisor.Queries
{
    public class GetAllSupervisorsHandler : IRequestHandler<GetAllSupervisorsQuery, List<Domain.Entities.Supervisor>>
    {
        private readonly IUnitOfService _UnitOfService;

        public GetAllSupervisorsHandler(IUnitOfService unitOfService) {
            _UnitOfService = unitOfService;
        }

        public async Task<List<Domain.Entities.Supervisor>> Handle(GetAllSupervisorsQuery request, CancellationToken cancellationToken) {

            return await _UnitOfService.SupervisorService.
        }
    }
}
