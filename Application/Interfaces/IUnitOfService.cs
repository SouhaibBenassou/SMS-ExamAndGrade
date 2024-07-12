using Application.IServices;

namespace Application.Interfaces
{
    public interface IUnitOfService
    {
        IExamService ExamService { get; set; }
        ISupervisorService SupervisorService { get; set; }
    }
}
