namespace Application.IServices;

public interface IExamSessionService
{
    Task<bool> CheckRoomAvailability(DateTime startDate, DateTime endDate, Guid roomId);
    Task<bool> CheckSupervisorAvailability(DateTime startDate, DateTime endDate, Guid supervisorId);
    DateTime CalculateEndTime(DateTime dateTime, string duratiom);
}