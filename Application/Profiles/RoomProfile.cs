using Application.Features.Rooms.Commands.Create;
using Application.Features.Rooms.Commands.Delete;
using Application.Features.Rooms.Commands.Update;
using Application.Features.Rooms.Queries.GetRoomById;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Profiles
{
    public class RoomProfile : Profile
    {
        public RoomProfile() {
            CreateMap<AddNewRoomCommand, Room>().ReverseMap();
            CreateMap<UpdateRoomCommand, Room>().ReverseMap();
            CreateMap<DeleteRoomCommand, Room>().ReverseMap();
            // Query Handlers
            CreateMap<Room, RoomDto>().ReverseMap();
            CreateMap<Room, GetRoomByIdQuery>().ReverseMap();
        }
    }
}
