
using Application.Features.Supervisor.Commands.Update;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class SupervisorProfile : Profile
    {
        public SupervisorProfile()
        {
            CreateMap<UpdateSupervisorCommand, Supervisor>().ReverseMap();
        }
    }
}
