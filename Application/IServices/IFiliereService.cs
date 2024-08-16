using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.IServices;

public interface IFiliereService
{
    Task<List<Filiere>> GetAllFilieresWithUnitOfFormations();
    Task<Filiere?> GetOneFiliereWithUnitOfFormations(Guid filiereId);
}