using Domain.Enums;
using MediatR;

namespace Application.Features.Rooms.Commands.Create
{
    public class AddNewRoomCommand : IRequest<string>
    {
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public string RoomName { get; set; }
    }
}
