using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.FormateurDto;
using MediatR;

namespace Application.Features.Formateur.Queries.GetListFormateurs;

public class GetListFormateursHandler : IRequestHandler<GetListFormateurs, List<FormateurDto>>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public GetListFormateursHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<List<FormateurDto>> Handle(GetListFormateurs request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<FormateurDto>>(await _unitOfService.FormateurService.GetAllFormatteur());
    }
}