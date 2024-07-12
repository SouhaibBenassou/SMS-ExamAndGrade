using Domain.Entities;

namespace Application.IRepository
{
    public interface IExamRepository : IAsyncRepository<Exam>
    {
        Task<List<Exam>> GetAllWithRelatedEntities();
    }
}
