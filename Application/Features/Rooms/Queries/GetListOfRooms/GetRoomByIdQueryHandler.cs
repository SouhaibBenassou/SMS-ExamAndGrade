using MediatR;
using Domain.Dtos;
using Application.IServices;
using Application.Features.Rooms.Queries.GetListOfRooms;

namespace Application.Features.Rooms.Queries.GetRoomById
{
    public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomDto>
    {
        private readonly IRoomService _roomService;

        public GetRoomByIdQueryHandler(IRoomService roomService) => _roomService = roomService;

        public async Task<RoomDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
        {
            return await _roomService.GetRoomByIdAsync(request.RoomId);
        }
    }
}
