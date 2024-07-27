using Application.Interfaces;
using Application.IServices;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        public ITestService TestService { get; set; }
        public ISupervisorService SupervisorService { get; set; }
        public IRoomService RoomService { get; set; }
        public IExamService ExamService { get; set; }
        public IVariantsExamService VariantsExamService { get; set; }
        public IExamResultsService ExamResultsService { get; set; }

        public UnitOfService(ITestService testService, ISupervisorService supervisorService, IRoomService roomService, IExamService examService, IVariantsExamService variantsExamService, IExamResultsService examResultsService) {
            TestService = testService;
            SupervisorService = supervisorService;
            RoomService = roomService;
            ExamService = examService;
            VariantsExamService = variantsExamService;
            ExamResultsService = examResultsService;
        }
    }
}
