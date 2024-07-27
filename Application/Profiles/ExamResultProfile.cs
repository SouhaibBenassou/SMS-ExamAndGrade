using Application.Features.Results.Command.update;
using AutoMapper;
using Domain;

namespace Application.Profiles
{
    public class ExamResultProfile : Profile
    {
        public ExamResultProfile() {
            CreateMap<ExamResult, UpdateExamResultsCommand>().ReverseMap();
        }
    }
}
