using Domain.Dtos.FiliereDto;
using MediatR;

namespace Application.Features.Filiere.Queries.GetListFiliereQuery;

public class GetListFiliereQuery : IRequest<List<FiliereDto>>
{
    public GetListFiliereQuery()
    {
    }
}