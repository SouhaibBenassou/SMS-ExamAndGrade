using Application.Interfaces;
using Application.IServices;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.Services;

public class FiliereService : IFiliereService
{
    private readonly IUnitOfWork _unitOfWork;

    public FiliereService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Filiere>> GetAllFilieresWithUnitOfFormations()
    {
        return await _unitOfWork.FiliereRepository.GetAllFilieresWithUnitOfFormations();
    }

    public async Task<Filiere?> GetOneFiliereWithUnitOfFormations(Guid filiereId)
    {
        return await _unitOfWork.FiliereRepository.GetOneFiliereWithUnitOfFormations(f=>f.Id == filiereId);
    }

}