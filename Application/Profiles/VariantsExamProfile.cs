using Application.Features.VariantsExam.Commands.Delete;
using Application.Features.VariantsExam.Commands.Update;
using Application.Features.VariantsExams.Commands.Create;
using Application.Features.VariantsExams.Queries.GetVariantsExamById;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Profiles
{
    public class VariantsExamProfile : Profile
    {
        public VariantsExamProfile()
        {
            CreateMap<CreateVariantsExamCommand, VariantsExamDto>().ReverseMap();
            CreateMap<VariantsExams, DeleteVariantsExamsCommand>().ReverseMap();
            CreateMap<VariantsExams, UpdateVariantsExamCommand>().ReverseMap();
            // Query Handlers
            CreateMap<VariantsExams, VariantsExamDto>().ReverseMap();
            CreateMap<VariantsExams, GetVariantsExamByIdQuery>().ReverseMap();

        }
    }
}
