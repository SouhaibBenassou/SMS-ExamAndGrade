using Domain.Entities;

namespace Application.IRepository;

public interface IExamSessionRepository : IAsyncRepository<ExamSession>
{
    Task<List<ExamSession>?> GetSessionsBetweenTimes(DateTime startDate, DateTime endDate, Guid roomId);
}