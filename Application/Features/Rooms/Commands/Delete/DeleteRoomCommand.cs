using MediatR;

namespace Application.Features.Rooms.Commands.Delete
{
    public class DeleteRoomCommand : IRequest<string>
    {
        public Guid RoomId { get; set; }
    }
}
