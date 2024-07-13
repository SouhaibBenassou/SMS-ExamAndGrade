using MediatR;
using Domain.Dtos;
using Application.IServices;

namespace Application.Features.Rooms.Queries.GetListOfRooms
{
    public class GetListOfRoomsQueryHandler : IRequestHandler<GetListOfRoomsQuery, IEnumerable<RoomDto>>
    {
        private readonly IRoomService _roomService;

        public GetListOfRoomsQueryHandler(IRoomService roomService) => _roomService = roomService;

        public async Task<IEnumerable<RoomDto>> Handle(GetListOfRoomsQuery request, CancellationToken cancellationToken)
        {
            return await _roomService.GetListOfRoomsAsync();
        }
    }
}

