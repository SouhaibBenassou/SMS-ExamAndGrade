using Domain.Dtos.FiliereDto;
using MediatR;

namespace Application.Features.Filiere.Queries.GetOneFiliereQuery;

public class GetOneFiliereQuery : IRequest<FiliereDto>
{
    public Guid FiliereId { get; set; }

    public GetOneFiliereQuery(Guid filiereId)
    {
        FiliereId = filiereId;
    }
}