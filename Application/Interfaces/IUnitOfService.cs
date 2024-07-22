using Application.IServices;

namespace Application.Interfaces
{
    public interface IUnitOfService
    {
        ITestService TestService { get; }
        IExamService ExamService { get; }
        ISupervisorService SupervisorService { get; }
        IRoomService RoomService { get; }
        IVariantsExamService VariantsExamService { get; }

    }
}
