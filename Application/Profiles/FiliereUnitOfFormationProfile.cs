using AutoMapper;
using Domain.Dtos.FiliereUnitOfFormationDto;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.Profiles;

public class FiliereUnitOfFormationProfile : Profile
{
    public FiliereUnitOfFormationProfile()
    {
        CreateMap<FiliereUnitOfFormation, FiliereUnitOfFormationDto>().ReverseMap();
    }
}