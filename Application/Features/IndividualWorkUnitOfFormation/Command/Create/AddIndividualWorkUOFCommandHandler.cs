using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.IndividualWorkUOFDtos;
using Domain.Entities;
using MediatR;

namespace Application.Features.IndividualWorkUnitOfFormation.Command.Create
{
    public class AddIndividualWorkUOFCommandHandler : IRequestHandler<AddIndividualWorkUOFCommand, GetIndividualWorkUOFDto>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public AddIndividualWorkUOFCommandHandler(IUnitOfService unitOfService, IMapper mapper) {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<GetIndividualWorkUOFDto> Handle(AddIndividualWorkUOFCommand request, CancellationToken cancellationToken) {

            var individualWorkUOF = _mapper.Map<IndividualWorkUOF>(request);

            var createdIndividualWorkUOF = await _unitOfService.IndividualWorkUOFService.CreateIndividualWorkUOF(individualWorkUOF);
            var resultDto = _mapper.Map<GetIndividualWorkUOFDto>(createdIndividualWorkUOF);
            return resultDto;

        }
    }
}
