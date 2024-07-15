using Application.Features.Rooms.Commands.Create;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Rooms.Handlers
{
    public class AddNewRoomCommandHandler : IRequestHandler<AddNewRoomCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public AddNewRoomCommandHandler(IUnitOfService unitOfService) => _unitOfService = unitOfService;

        public async Task<string> Handle(AddNewRoomCommand request, CancellationToken cancellationToken) {

            var room = new Room
            {
                Capacity = request.Capacity,
                RoomType = request.RoomType,
                RoomName = request.RoomName,
            };


            return await _unitOfService.RoomService.AddRoomAsync(room);
        }
    }
}

