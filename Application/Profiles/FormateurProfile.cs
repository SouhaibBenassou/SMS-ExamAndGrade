using AutoMapper;
using Domain.Dtos.FormateurDto;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.Profiles;

public class FormateurProfile  : Profile
{
    public FormateurProfile()
    {
        CreateMap<Formateur, FormateurDto>().ReverseMap();
    }
}