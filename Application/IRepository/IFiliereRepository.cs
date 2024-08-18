using System.Linq.Expressions;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.IRepository;

public interface IFiliereRepository : IAsyncRepository<Filiere>
{
    Task<List<Filiere>> GetAllFilieresWithUnitOfFormations(Expression<Func<Filiere, bool>>? filter = null);
    Task<Filiere?> GetOneFiliereWithUnitOfFormations(Expression<Func<Filiere, bool>>? filter = null);
}