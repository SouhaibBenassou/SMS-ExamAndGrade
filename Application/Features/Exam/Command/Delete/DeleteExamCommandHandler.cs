using Application.Interfaces;
using MediatR;

namespace Application.Features.Exam.Command.Delete
{
    public class DeleteExamCommandHandler : IRequestHandler<DeleteExamCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public DeleteExamCommandHandler(IUnitOfService unitOfService) {
            _unitOfService = unitOfService;
        }

        public Task<string> Handle(DeleteExamCommand request, CancellationToken cancellationToken) {
            return _unitOfService.ExamService.DeleteExamAsync(request.ExamId);
        }
    }
}
