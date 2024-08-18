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


    }
}