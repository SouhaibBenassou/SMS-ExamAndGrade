using Application.Interfaces;
using Application.IRepository;
using MediatR;


namespace Application.Features.Supervisor.Commands.Update
{
    public class UpdateSupervisorHandler : IRequestHandler<UpdateSupervisorCommand, Unit>
    {
        private readonly ISupervisorRepository _supervisorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateSupervisorHandler(ISupervisorRepository supervisorRepository, IUnitOfWork unitOfWork)
        {
            _supervisorRepository = supervisorRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateSupervisorCommand request, CancellationToken cancellationToken)
        {
            var supervisor = request.Supervisor;
            await _supervisorRepository.UpdateAsync(supervisor);
            await _unitOfWork.CommitAsync();
            return Unit.Value;
        }

    }
}
