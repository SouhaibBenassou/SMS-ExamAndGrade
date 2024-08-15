using Application.Features.IndividualWorkUnitOfFormation.Command.Update;
using Application.Features.IndividualWorkUnitOfFormation.Exeptions;
using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.IndividualWorkUOFDtos;
using MediatR;

public class UpdateIndividualWorkUOFCommandHandler : IRequestHandler<UpdateIndividualWorkUOFCommand, GetIndividualWorkUOFDto>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public UpdateIndividualWorkUOFCommandHandler(IUnitOfService unitOfService, IMapper mapper) {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<GetIndividualWorkUOFDto> Handle(UpdateIndividualWorkUOFCommand request, CancellationToken cancellationToken) {
        // Fetch the existing entity from the database
        var individualWorkUOF = await _unitOfService.IndividualWorkUOFService.GetIndividualWorkUOFByID(request.IndividualWorkUOFId);

        if (individualWorkUOF == null)
        {
            throw new individualWorkUOFNotFound(request.IndividualWorkUOFId);
        }

        // Apply the updates from the request object to the entity
        _mapper.Map(request, individualWorkUOF);

        // Update the entity in the database
        var updatedIndividualWorkUOF = await _unitOfService.IndividualWorkUOFService.UpdateIndividualWorkUOF(individualWorkUOF);

        // Map the updated entity to the DTO and return it
        var resultDto = _mapper.Map<GetIndividualWorkUOFDto>(updatedIndividualWorkUOF);
        return resultDto;
    }
}
