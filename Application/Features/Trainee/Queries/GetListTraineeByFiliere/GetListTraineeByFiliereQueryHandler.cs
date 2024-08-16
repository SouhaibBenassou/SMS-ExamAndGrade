using Application.Interfaces;
using MediatR;

namespace Application.Features.Trainee.Queries.GetListTraineeByFiliere;

public class GetListTraineeByFiliereQueryHandler : IRequestHandler<GetListTraineeByFiliereQuery,List<Domain.EntitiesFromOtherServices.Trainee>>
{
    private readonly IUnitOfService _unitOfService;

    public GetListTraineeByFiliereQueryHandler(IUnitOfService unitOfService)
    {
        _unitOfService = unitOfService;
    }


    public async Task<List<Domain.EntitiesFromOtherServices.Trainee>> Handle(GetListTraineeByFiliereQuery request, CancellationToken cancellationToken)
    {
        return (await _unitOfService.TraineeService.GetAllTrainee()).Where(t=>t.IdFiliere == request.FiliereId).ToList();
    }
}