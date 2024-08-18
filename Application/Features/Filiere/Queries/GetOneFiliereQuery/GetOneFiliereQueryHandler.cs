using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.FiliereDto;
using MediatR;

namespace Application.Features.Filiere.Queries.GetOneFiliereQuery;

public class GetOneFiliereQueryHandler : IRequestHandler<GetOneFiliereQuery,FiliereDto>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public GetOneFiliereQueryHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<FiliereDto> Handle(GetOneFiliereQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<FiliereDto>(await _unitOfService.FiliereService.GetOneFiliereWithUnitOfFormations(request.FiliereId));
    }
}