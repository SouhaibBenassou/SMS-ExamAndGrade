using AutoMapper;
using Domain;
using Domain.Dtos.TestResultDto;
using Domain.Entities;

namespace Application.Profiles;

public class TestResultProfile : Profile
{
    public TestResultProfile()
    {
        CreateMap<TestResult, TestResultDto>().ReverseMap();
    }
}