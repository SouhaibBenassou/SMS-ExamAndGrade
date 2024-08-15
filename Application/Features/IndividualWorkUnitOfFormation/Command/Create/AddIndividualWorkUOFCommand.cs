using Domain.Dtos.IndividualWorkUOFDtos;
using MediatR;

namespace Application.Features.IndividualWorkUnitOfFormation.Command.Create
{
    public class AddIndividualWorkUOFCommand : IRequest<GetIndividualWorkUOFDto>
    {
        public string? Name { get; set; }
        public int? Confusion { get; set; }
    }
}
