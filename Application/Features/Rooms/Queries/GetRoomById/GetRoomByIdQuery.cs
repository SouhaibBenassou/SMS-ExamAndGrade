using Domain.Dtos;
using MediatR;

namespace Application.Features.Rooms.Queries.GetRoomById
{
    public class GetRoomByIdQuery(Guid id) : IRequest<RoomDto>
    {
        public Guid RoomId { get; set; } = id;
    }
}
