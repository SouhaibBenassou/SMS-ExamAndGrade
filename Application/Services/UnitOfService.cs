using Application.Interfaces;
using Application.IServices;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {

        public ISupervisorService SupervisorService { get; set; }
        public IRoomService RoomService { get; set; }
        public IExamService ExamService { get; set; }

        public UnitOfService(ISupervisorService supervisorService, IRoomService roomService, IExamService examService) {
            SupervisorService = supervisorService;
            RoomService = roomService;
            ExamService = examService;
        }
    }
}
