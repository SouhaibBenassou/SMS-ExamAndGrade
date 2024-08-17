using Application.Features.IndividualWorkUnitOfFormation.Command.Create;
using Application.Features.IndividualWorkUnitOfFormation.Command.Update;
using AutoMapper;
using Domain.Dtos.IndividualWorkUOFDtos;
using Domain.Entities;

namespace Application.Profiles
{
    public class IndividualWorkUOFProfile : Profile
    {
        public IndividualWorkUOFProfile() {
            CreateMap<AddIndividualWorkUOFCommand, IndividualWorkUOF>();
            CreateMap<IndividualWorkUOF, GetIndividualWorkUOFDto>();
            CreateMap<UpdateIndividualWorkUOFCommand, IndividualWorkUOF>();
        }
    }
}
