using Application.Interfaces;
using Application.IRepository;
using AutoMapper;
using Domain.Dtos.SupervisorDto;
using Domain.Entities;
using MediatR;


namespace Application.Features.Supervisor.Commands.Update
{
    public class UpdateSupervisorHandler : IRequestHandler<UpdateSupervisorCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public UpdateSupervisorHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateSupervisorCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Supervisor updateSupervisor = new Domain.Entities.Supervisor
      
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Title = request.Title,
            };

            return await _unitOfService.SupervisorService.UpdateSupervisorAsync(updateSupervisor);
        }

    }
}
