using Domain.Dtos;
using MediatR;

namespace Application.Features.Rooms.Queries.GetListOfRooms
{
    public class GetRoomByIdQuery : IRequest<RoomDto>
    {
        public Guid RoomId { get; }

        public GetRoomByIdQuery(Guid roomId)
        {
            RoomId = roomId;
        }
    }
}
