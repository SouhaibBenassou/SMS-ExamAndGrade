using Application.Interfaces;
using Application.IRepository;
using MediatR;

namespace Application.Features.Supervisor.Commands.Delete
{
    public class DeleteSupervisorHandler : IRequestHandler<DeleteSupervisorCommand, string>
    {
        private readonly ISupervisorRepository _supervisorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteSupervisorHandler(ISupervisorRepository supervisorRepository, IUnitOfWork unitOfWork)
        {
            _supervisorRepository = supervisorRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(DeleteSupervisorCommand request, CancellationToken cancellationToken)
        {
            var supervisor = await _supervisorRepository.GetAsTracking(s => s.Id == request.SupervisorId);
            if (supervisor != null)
            {
                await _supervisorRepository.RemoveAsync(supervisor);
                await _unitOfWork.CommitAsync();
            }
            return "delete success";
        }
    }

}
