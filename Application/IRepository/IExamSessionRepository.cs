using Domain.Entities;

namespace Application.IRepository;

public interface IExamSessionRepository : IAsyncRepository<ExamSession>
{
    Task<List<ExamSession>?> GetSessionsBetweenTimes(DateTime startDate, DateTime endDate, Guid roomId);

    Task<List<ExamSession>?> GetSessionsBetweenTimesForSupervisor(DateTime startDate, DateTime endDate,
        Guid supervisorId);
}