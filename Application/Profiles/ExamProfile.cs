using AutoMapper;
using Domain.Dtos.ExamDto;
using Domain.Entities;

namespace Application.Profiles
{
    public class ExamProfile : Profile
    {
        public ExamProfile() {
            CreateMap<Exam, GetListExamDto>().ReverseMap();
        }
    }
}
