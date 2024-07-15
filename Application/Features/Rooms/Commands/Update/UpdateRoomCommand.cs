using Domain.Enums;
using MediatR;

namespace Application.Features.Rooms.Commands.Update
{
    public class UpdateRoomCommand : IRequest<string>
    {

        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public string RoomName { get; set; }
    }
}

