using Application.Interfaces;
using MediatR;

namespace Application.Features.TestResult.Command.Delete;

public class DeleteTestResultCommandHandler : IRequestHandler<DeleteTestResultCommand,bool>
{
    private readonly IUnitOfService _unitOfService;

    public DeleteTestResultCommandHandler(IUnitOfService unitOfService)
    {
        _unitOfService = unitOfService;
    }

    public async Task<bool> Handle(DeleteTestResultCommand request, CancellationToken cancellationToken)
    {
        await _unitOfService.TestResultService.DeleteOneTestResult(request.Id);
        return true;
    }
}