using Application.Features.Exam.Command.Delete;
using Application.Features.Test.Command.Create;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Profiles
{
    internal class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<CreateTestCommand, Test>().ReverseMap();
           
            CreateMap<DeleteTestCommand, Room>().ReverseMap();
            // Query Handlers
            CreateMap<Room, RoomDto>().ReverseMap();
          
        }
    }
}
