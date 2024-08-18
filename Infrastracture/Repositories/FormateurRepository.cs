using Application.IRepository;
using Domain.EntitiesFromOtherServices.FiliereService;
using Infrastructure.Data;

namespace Infrastracture.Repositories;

public class FormateurRepository : AsyncRepository<Formateur> , IFormateurRepository
{
    public FormateurRepository(ApplicationDbContext db) : base(db)
    {
    }
}