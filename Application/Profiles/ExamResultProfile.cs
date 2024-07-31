using Application.Features.Results.Command.update;
using AutoMapper;
using Domain;
using Domain.Dtos.ResultsDto;

namespace Application.Profiles
{
    public class ExamResultProfile : Profile
    {
        public ExamResultProfile() {
            CreateMap<ExamResult, UpdateExamResultsCommand>().ReverseMap();
            CreateMap<StagiaireNoteDetailDto, ExamResult>()
            .ForMember(dest => dest.PracticalNote, opt => opt.Condition(src => src.PracticalNote.HasValue))
            .ForMember(dest => dest.TheoreticalNote, opt => opt.Condition(src => src.TheoreticalNote.HasValue));
            CreateMap<UpdateExamResultsCommand, StagiaireNoteDetailDto>().ReverseMap();
            CreateMap<ExamResult, StagiaireNoteDetailDto>().ReverseMap();
            CreateMap<ExamResult, ListExamResutlsDto>().ReverseMap();
        }
    }
}
