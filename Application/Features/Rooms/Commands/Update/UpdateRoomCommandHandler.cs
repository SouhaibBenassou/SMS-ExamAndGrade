using Application.Features.Rooms.Commands.Update;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Rooms.Handlers
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public UpdateRoomCommandHandler(IUnitOfService unitOfService, IMapper mapper) {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateRoomCommand request, CancellationToken cancellationToken) {

            Room updateRoom = new Room
            {
                Id = request.Id,
                RoomType = request.RoomType,
                Capacity = request.Capacity,
                RoomName = request.RoomName,
            };

            return await _unitOfService.RoomService.UpdateRoomAsync(updateRoom);
        }
    }
}
