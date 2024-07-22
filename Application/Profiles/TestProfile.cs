using AutoMapper;
using Domain;
using Domain.Dtos.TestDtos;

namespace Application.Profiles
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<Test, ListTestDtos>().ReverseMap();
            CreateMap<Test, AddTestCommand>().ReverseMap();
            CreateMap<Test, TestDto>().ReverseMap();
        }
    }
}
