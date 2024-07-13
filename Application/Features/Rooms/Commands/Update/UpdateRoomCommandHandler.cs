using Application.Features.Rooms.Commands.Update;
using Application.IServices;
using Domain.Entities;
using MediatR;

namespace Application.Features.Rooms.Handlers
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, string>
    {
        private readonly IRoomService _roomService;

        public UpdateRoomCommandHandler(IRoomService roomService) => _roomService = roomService;

        public async Task<string> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var room = new Room
            {
                Id = request.RoomId,
                Capacity = request.Capacity,
                RoomType = request.RoomType
            };

            return await _roomService.UpdateRoomAsync(room);
        }
    }
}
