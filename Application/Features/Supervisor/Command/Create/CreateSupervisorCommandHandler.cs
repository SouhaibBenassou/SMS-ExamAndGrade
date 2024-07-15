using Application.Interfaces;
using MediatR;

namespace Application.Features.Supervisor.command.Create
{
    public class CreateSupervisorCommandHandler : IRequestHandler<CreateSupervisorCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public CreateSupervisorCommandHandler(IUnitOfService unitOfService) {
            _unitOfService = unitOfService;
        }

        public async Task<string> Handle(CreateSupervisorCommand request, CancellationToken cancellationToken) {

            var supervisor = new Domain.Entities.Supervisor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Title = request.Title,
            };
            return await _unitOfService.SupervisorService.AddSupervisorAsync(supervisor);
        }


    }
}

