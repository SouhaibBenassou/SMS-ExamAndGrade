using Application.IServices;

namespace Application.Interfaces
{
    public interface IUnitOfService
    {
        IExamService ExamService { get; }
        ISupervisorService SupervisorService { get; }
        IRoomService RoomService { get; }
        ITestService TestService { get; }


    }
}
