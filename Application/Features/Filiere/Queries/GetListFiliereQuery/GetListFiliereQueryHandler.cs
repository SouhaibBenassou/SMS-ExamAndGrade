using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.FiliereDto;
using MediatR;

namespace Application.Features.Filiere.Queries.GetListFiliereQuery;

public class GetListFiliereQueryHandler :  IRequestHandler<GetListFiliereQuery,List<FiliereDto>>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public GetListFiliereQueryHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<List<FiliereDto>> Handle(GetListFiliereQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<FiliereDto>>(await _unitOfService.FiliereService.GetAllFilieresWithUnitOfFormations());
    }
}