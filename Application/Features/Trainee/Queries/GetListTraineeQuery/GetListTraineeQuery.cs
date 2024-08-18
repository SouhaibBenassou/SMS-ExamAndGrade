using MediatR;

namespace Application.Features.Trainee.Queries.GetListTraineeQuery;

public class GetListTraineeQuery : IRequest<List<Domain.EntitiesFromOtherServices.Trainee>>
{
    public GetListTraineeQuery()
    {
    }
}