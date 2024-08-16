using MediatR;

namespace Application.Features.Trainee.Queries.GetListTraineeByFiliere;

public class GetListTraineeByFiliereQuery : IRequest<List<Domain.EntitiesFromOtherServices.Trainee>>
{
    public Guid FiliereId { get; set; }

    public GetListTraineeByFiliereQuery(Guid filiereId)
    {
        FiliereId = filiereId;
    }
}