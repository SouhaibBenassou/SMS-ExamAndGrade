using Application.Features.Exam.Command.Create;
using AutoMapper;
using Domain;
using Domain.Dtos.ExamDto;
using Domain.Dtos.FiliereDto;
using Domain.Entities;

namespace Application.Profiles
{
    public class ExamProfile : Profile
    {
        public ExamProfile()
        {
            CreateMap<Exam, GetListExamDto>().ReverseMap().ForMember(x => x.Year, opt => opt.MapFrom(src => src.Year));
            CreateMap<Year, YearDto>().ReverseMap();
            CreateMap<CreateExamCommand, Exam>().ReverseMap();
            CreateMap<Exam, ExamResultDto>().ReverseMap();
            CreateMap<Filiere, FiliereNameDto>().ReverseMap();
        }
    }
}
