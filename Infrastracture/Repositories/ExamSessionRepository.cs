using Application.IRepository;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories;

public class ExamSessionRepository : AsyncRepository<ExamSession> , IExamSessionRepository
{
    private readonly ApplicationDbContext _db;

    public ExamSessionRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<List<ExamSession>?> GetSessionsBetweenTimes(DateTime startDate, DateTime endDate, Guid roomId)
    {
         return await _db.ExamSessions.AsNoTracking()
            .Where(es => es.RoomId == roomId && es.StartTime < endDate &&  es.EndTime > startDate)
            .ToListAsync();;
    } 
    
}