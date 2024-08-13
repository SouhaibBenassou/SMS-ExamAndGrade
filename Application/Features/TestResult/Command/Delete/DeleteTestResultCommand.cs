using MediatR;

namespace Application.Features.TestResult.Command.Delete;

public class DeleteTestResultCommand : IRequest<bool>
{
    public Guid Id { get; set; }

    public DeleteTestResultCommand(Guid id)
    {
        Id = id;
    }
}