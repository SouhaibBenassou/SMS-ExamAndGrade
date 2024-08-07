using Application.Interfaces;
using Application.IServices;
using Domain;
using Domain.Entities;

namespace Application.Services;

public class ExamSessionService : IExamSessionService
{
    private readonly IUnitOfWork _unitOfWork;

    public ExamSessionService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async Task<bool> CheckRoomAvailability(DateTime startDate, DateTime endDate, Guid roomId)
    {
        List<ExamSession> examSessions = await _unitOfWork.ExamSessionRepository.GetSessionsBetweenTimes(startDate,endDate,roomId);
        if (examSessions is null || !examSessions.Any())
        {
            return true;
        }
        return false;
    }
}