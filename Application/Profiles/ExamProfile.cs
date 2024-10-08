﻿using Application.Features.Exam.Command.Create;
using AutoMapper;
using Domain;
using Domain.Dtos.ExamDto;
using Domain.Entities;

namespace Application.Profiles
{
    public class ExamProfile : Profile
    {
        public ExamProfile() {
            CreateMap<Exam, GetListExamDto>().ReverseMap();
            CreateMap<CreateExamCommand, Exam>().ReverseMap();
            CreateMap<Exam, ExamResultDto>().ReverseMap();
        }
    }
}
