using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.IServices;

public interface IFormateurService
{
    Task<List<Formateur>> GetAllFormatteur();
}