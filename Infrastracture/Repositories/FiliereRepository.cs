using System.Linq.Expressions;
using Application.IRepository;
using Domain.EntitiesFromOtherServices.FiliereService;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories;

public class FiliereRepository : AsyncRepository<Filiere> , IFiliereRepository
{
    private readonly ApplicationDbContext _db;
    public FiliereRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<List<Filiere>> GetAllFilieresWithUnitOfFormations(Expression<Func<Filiere, bool>>? filter = null)
    {
        return await _db.Filieres
            .AsNoTracking()
            .Include(f => f.FiliereUnitOfFormations).ThenInclude(fuf=>fuf.UnitOfFormation)
            .ToListAsync();
    }

    public async Task<Filiere?> GetOneFiliereWithUnitOfFormations(Expression<Func<Filiere, bool>>? filter = null)
    {
        IQueryable<Filiere> query = dbSet.AsNoTracking().Include(f => f.FiliereUnitOfFormations).ThenInclude(fuf=>fuf.UnitOfFormation);
        if (filter != null)
        {
            query = query.Where(filter);
        }
        return await query.FirstOrDefaultAsync();
    }
}