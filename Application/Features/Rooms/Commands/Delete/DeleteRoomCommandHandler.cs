using Application.Features.Rooms.Commands.Delete;
using Application.IServices;
using MediatR;

namespace Application.Features.Rooms.Handlers
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, string>
    {
        private readonly IRoomService _roomService;

        public DeleteRoomCommandHandler(IRoomService roomService) => _roomService = roomService;

        public async Task<string> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            return await _roomService.DeleteRoomAsync(request.RoomId);
        }
    }
}
