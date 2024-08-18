using AutoMapper;
using Domain.Dtos.UnitOfFormationDto;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.Profiles;

public class UnitOfFormationProfile : Profile
{
    public UnitOfFormationProfile()
    {
        CreateMap<UnitOfFormationDto, UnitOfFormation>().ReverseMap();
    }
}