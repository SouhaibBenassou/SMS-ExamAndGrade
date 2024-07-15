using Domain.Dtos;
using MediatR;

namespace Application.Features.Rooms.Queries.GetListOfRooms
{
    public class GetListOfRoomsQuery : IRequest<List<RoomDto>>
    {

    }
}
