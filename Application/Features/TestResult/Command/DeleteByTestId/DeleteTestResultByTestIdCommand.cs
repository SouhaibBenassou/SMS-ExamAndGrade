using MediatR;

namespace Application.Features.TestResult.Command.DeleteByTestId;

public class DeleteTestResultByTestIdCommand : IRequest<bool>
{
    public Guid TestId { get; set; }

    public DeleteTestResultByTestIdCommand(Guid testId)
    {
        TestId = testId;
    }
}