using AutoMapper;
using Domain.Dtos.ExamSessionDto;
using Domain.Entities;

namespace Application.Profiles;

public class ExamSessionProfile : Profile
{
    public ExamSessionProfile()
    {
        CreateMap<ExamSession, ExamSessionDto>().ReverseMap();
    }
}