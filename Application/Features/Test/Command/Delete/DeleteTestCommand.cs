using MediatR;

namespace Application;

public class DeleteTestCommand(Guid id) : IRequest<string>
{
    public Guid TestId { get; set; } = id;
}
