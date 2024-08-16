using Application.Interfaces;
using MediatR;

namespace Application.Features.Trainee.Queries.GetListTraineeQuery;

public class GetListTraineeQueryHandler : IRequestHandler<GetListTraineeQuery,List<Domain.EntitiesFromOtherServices.Trainee>>
{
    private readonly IUnitOfService _unitOfService;

    public GetListTraineeQueryHandler(IUnitOfService unitOfService)
    {
        _unitOfService = unitOfService;
    }

    public async Task<List<Domain.EntitiesFromOtherServices.Trainee>> Handle(GetListTraineeQuery request, CancellationToken cancellationToken)
    {
        return await _unitOfService.TraineeService.GetAllTrainee();
    }
}