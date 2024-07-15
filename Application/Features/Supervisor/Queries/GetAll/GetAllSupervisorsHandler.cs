using Application.Interfaces;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using MediatR;


namespace Application.Features.Supervisor.Queries
{
    public class GetAllSupervisorsHandler : IRequestHandler<GetAllSupervisorsQuery, List<Domain.Entities.Supervisor>>
    {
        private readonly IUnitOfService _unitofService;
        private readonly IMapper _mapper;

        public GetAllSupervisorsHandler(IUnitOfService unitofService, IMapper mapper)
        {
            _unitofService = unitofService;
            _mapper = mapper;
        }

        public async Task<List<Domain.Entities.Supervisor>> Handle(GetAllSupervisorsQuery request, CancellationToken cancellationToken)
        {


            List<Domain.Entities.Supervisor> listSupervisor = await _unitofService.SupervisorService.GetListOfSupervisorsAsync();
           
            return listSupervisor;
        }
    }
}
