using Application.Interfaces;
using Application.IServices;
using Domain.EntitiesFromOtherServices.FiliereService;

namespace Application.Services;

public class FormateurService : IFormateurService
{
    private readonly IUnitOfWork _unitOfWork;

    public FormateurService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Formateur>> GetAllFormatteur()
    {
        return await _unitOfWork.FormateurRepository.GetAllAsNoTracking();
    }
}