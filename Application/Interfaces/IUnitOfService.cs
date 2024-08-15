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
        IExamResultsService ExamResultsService { get; }
        ITestResultService TestResultService { get;}
        IStagiereNoteService StagiereNoteService { get;}
        IExamSessionService ExamSessionService { get; }
        ITestResultService TestResultService { get; }
        IStagiereNoteService StagiereNoteService { get; }
        IIndividualWorkUOFService IndividualWorkUOFService { get; }

    }
}
