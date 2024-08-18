using AutoMapper;
using Domain.Dtos.FiliereDto;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.Profiles;

public class FiliereProfile : Profile
{
    public FiliereProfile()
    {
        CreateMap<Filiere, FiliereDto>().ReverseMap();
    }
}