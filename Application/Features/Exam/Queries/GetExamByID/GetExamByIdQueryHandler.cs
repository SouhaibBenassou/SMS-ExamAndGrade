using MediatR;

namespace Application;

public class GetExamByIdQueryHandler(Guid id) : IRequest<string>
{
    public Guid RoomId { get; set; } = id;
}
