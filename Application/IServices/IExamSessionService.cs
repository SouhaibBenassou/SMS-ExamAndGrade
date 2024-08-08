namespace Application.IServices;

public interface IExamSessionService
{
    Task<bool> CheckRoomAvailability(DateTime startDate, DateTime endDate, Guid roomId);
    DateTime CalculateEndTime(DateTime dateTime, string duratiom);
}