using Domain.Entities;

namespace Application.IServices
{
    public interface IIndividualWorkUOFService
    {
        Task<IndividualWorkUOF> CreateIndividualWorkUOF(IndividualWorkUOF individualWorkUOF);
        Task<IndividualWorkUOF> UpdateIndividualWorkUOF(IndividualWorkUOF individualWorkUOF);
        Task<IndividualWorkUOF> GetIndividualWorkUOFByID(Guid id);
        Task<List<IndividualWorkUOF>> GetAllIndividualWorkUOFs();
    }
}
