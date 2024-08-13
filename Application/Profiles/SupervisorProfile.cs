
using Application.Features.Supervisor.Commands.Update;
using AutoMapper;
using Domain.Dtos.SupervisorDto;
using Domain.Entities;

namespace Application.Profiles
{
    public class SupervisorProfile : Profile
    {
        public SupervisorProfile()
        {
            CreateMap<UpdateSupervisorCommand, Supervisor>().ReverseMap();
            CreateMap<Supervisor, SupervisorDto>().ReverseMap();
        }
    }
}
