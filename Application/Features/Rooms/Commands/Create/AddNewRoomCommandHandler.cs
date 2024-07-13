using Application.Features.Rooms.Commands.Create;
using Application.IServices;
using Domain.Entities;
using MediatR;

namespace Application.Features.Rooms.Handlers
{
    public class AddNewRoomCommandHandler : IRequestHandler<AddNewRoomCommand, string>
    {
        private readonly IRoomService _roomService;

        public AddNewRoomCommandHandler(IRoomService roomService) => _roomService = roomService;

        public async Task<string> Handle(AddNewRoomCommand request, CancellationToken cancellationToken)
        {
            var room = new Room
            {
                Capacity = request.Capacity,
                RoomType = request.RoomType
            };

            return await _roomService.AddRoomAsync(room);
        }
    }
}

