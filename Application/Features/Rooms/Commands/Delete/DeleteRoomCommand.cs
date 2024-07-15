using MediatR;

namespace Application.Features.Rooms.Commands.Delete
{
    public class DeleteRoomCommand(Guid id) : IRequest<string>
    {
        public Guid RoomId { get; set; } = id;
    }
}
