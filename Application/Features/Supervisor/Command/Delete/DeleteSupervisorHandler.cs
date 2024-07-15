using Application.Interfaces;
using Application.IRepository;
using Application.IServices;
using MediatR;

namespace Application.Features.Supervisor.Commands.Delete
{
    public class DeleteSupervisorHandler : IRequestHandler<DeleteSupervisorCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public DeleteSupervisorHandler(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }

        public async Task<string> Handle(DeleteSupervisorCommand request, CancellationToken cancellationToken)
        {
            
            return await _unitOfService.SupervisorService.DeleteSupervisorAsync(request.SupervisorId);
        }
    }

}
