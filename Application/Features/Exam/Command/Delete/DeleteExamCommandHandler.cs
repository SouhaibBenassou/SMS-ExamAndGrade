using Application.Interfaces;
using MediatR;

namespace Application.Features.Exam.Command.Delete
{
    public class DeleteExamCommandHandler : IRequestHandler<DeleteTestCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public DeleteExamCommandHandler(IUnitOfService unitOfService) {
            _unitOfService = unitOfService;
        }

        public Task<string> Handle(DeleteTestCommand request, CancellationToken cancellationToken) {
            return _unitOfService.ExamService.DeleteExamAsync(request.ExamId);
        }
    }
}
