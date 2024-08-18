using Application.Interfaces;
using Application.IServices;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        public IIndividualWorkUOFService IndividualWorkUOFService { get; set; }
        public ITestService TestService { get; set; }
        public ISupervisorService SupervisorService { get; set; }
        public IRoomService RoomService { get; set; }
        public IExamService ExamService { get; set; }
        public IVariantsExamService VariantsExamService { get; set; }
        public IExamResultsService ExamResultsService { get; set; }
        public ITestResultService TestResultService { get; set; }
        public IStagiereNoteService StagiereNoteService { get; set; }
        public IExamSessionService ExamSessionService { get; set; }
        public ITraineeService TraineeService { get; set; }
        public IFiliereService FiliereService { get; set; }
        public IFormateurService FormateurService { get; set; }

        public UnitOfService(IIndividualWorkUOFService individualWorkUofService, ITestService testService, ISupervisorService supervisorService, IRoomService roomService, IExamService examService, IVariantsExamService variantsExamService, IExamResultsService examResultsService, ITestResultService testResultService, IStagiereNoteService stagiereNoteService, IExamSessionService examSessionService, ITraineeService traineeService, IFiliereService filiereService, IFormateurService formateurService)
        {
            IndividualWorkUOFService = individualWorkUofService;
            TestService = testService;
            SupervisorService = supervisorService;
            RoomService = roomService;
            ExamService = examService;
            VariantsExamService = variantsExamService;
            ExamResultsService = examResultsService;
            TestResultService = testResultService;
            StagiereNoteService = stagiereNoteService;
            ExamSessionService = examSessionService;
            TraineeService = traineeService;
            FiliereService = filiereService;
            FormateurService = formateurService;
        }
    }
}