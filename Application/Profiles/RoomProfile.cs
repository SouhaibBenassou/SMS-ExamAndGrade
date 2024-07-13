using Application.Features.Rooms.Commands.Create;
using Application.Features.Rooms.Commands.Delete;
using Application.Features.Rooms.Commands.Update;
using Application.Features.Rooms.Queries.GetListOfRooms;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Profiles
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<AddNewRoomCommand, Room>();
            CreateMap<UpdateRoomCommand, Room>();
            CreateMap<DeleteRoomCommand, Room>();

            // Query Handlers
            CreateMap<Room, RoomDto>();
            CreateMap<Room, GetRoomByIdQuery>();
        }
    }
}
