//using Application.Interfaces;
//using Domain.Dtos;
//using MediatR;


//namespace Application.Features.Supervisor.Queries
//{
//    public class GetAllSupervisorsHandler : IRequestHandler<GetAllSupervisorsQuery, List<Supervisor>>
//    {
//        private readonly IUnitOfService _UnitOfService;

//        public GetAllSupervisorsHandler(IUnitOfService unitOfService) {
//            _UnitOfService = unitOfService;
//        }

//        public async Task<List<SupervisorDto>> Handle(GetAllSupervisorsQuery request, CancellationToken cancellationToken) {

//            return await _UnitOfService.SupervisorService;
//        }
//    }
//}
