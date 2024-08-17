using Domain.Dtos.IndividualWorkUOFDtos;
using MediatR;

namespace Application.Features.IndividualWorkUnitOfFormation.Queries.GetListIndividualWorkUOF
{
    public class GetListIndividualWorkUOFQuery : IRequest<List<GetIndividualWorkUOFDto>>
    {
    }
}
