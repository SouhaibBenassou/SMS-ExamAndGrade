using Application.Features.IndividualWorkUnitOfFormation.Queries.GetListIndividualWorkUOF;
using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.IndividualWorkUOFDtos;
using Domain.Entities;
using MediatR;

namespace Application.Features.IndividualWorkUnitOfFormation.Queries.GetListIndividualWorkUOFQueryHanlder
{
    public class GetListIndividualWorkUOFQueryHandler : IRequestHandler<GetListIndividualWorkUOFQuery, List<GetIndividualWorkUOFDto>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetListIndividualWorkUOFQueryHandler(IUnitOfService unitOfService, IMapper mapper) {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<List<GetIndividualWorkUOFDto>> Handle(GetListIndividualWorkUOFQuery request, CancellationToken cancellationToken) {
            List<IndividualWorkUOF> individualWorks = await _unitOfService.IndividualWorkUOFService.GetAllIndividualWorkUOFs();
            return _mapper.Map<List<GetIndividualWorkUOFDto>>(individualWorks);
        }
    }
}
