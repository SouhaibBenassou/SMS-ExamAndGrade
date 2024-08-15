using Domain.Dtos.IndividualWorkUOFDtos;
using MediatR;

namespace Application.Features.IndividualWorkUnitOfFormation.Command.Update
{
    public class UpdateIndividualWorkUOFCommand : IRequest<GetIndividualWorkUOFDto>
    {
        public Guid IndividualWorkUOFId { get; set; }
        public string? Name { get; set; }
        public int? Confusion { get; set; }
    }
}
