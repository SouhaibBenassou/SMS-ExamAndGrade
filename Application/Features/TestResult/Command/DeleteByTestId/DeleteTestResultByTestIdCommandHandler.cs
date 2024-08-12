using Application.Interfaces;
using MediatR;

namespace Application.Features.TestResult.Command.DeleteByTestId;

public class DeleteTestResultByTestIdCommandHandler : IRequestHandler<DeleteTestResultByTestIdCommand,bool>
{
    private readonly IUnitOfService _unitOfService;

    public DeleteTestResultByTestIdCommandHandler(IUnitOfService unitOfService)
    {
        _unitOfService = unitOfService;
    }

    public async Task<bool> Handle(DeleteTestResultByTestIdCommand request, CancellationToken cancellationToken)
    {
        await _unitOfService.TestResultService.DeleteTestResultOfTest(request.TestId);
        return true;
    }
}