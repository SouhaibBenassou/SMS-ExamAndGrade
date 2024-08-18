using Application.IRepository;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        public ITestRepository TestRepository { get; }
        public ISupervisorRepository SupervisorRepository { get; set; }
        public IExamRepository ExamRepository { get; set; }
        public IRoomRepository RoomRepository { get; set; }
        public IVariantsExamRepository VariantsExamRepository { get; set; }
        public IExamResultRepository ExamResultRepository { get; set; }
        public ITestResultRepository TestResultRepository { get; set; }
        public IExamSessionRepository ExamSessionRepository { get; set; }
        public IIndividualWorkUOFRepository IndividualWorkUOFRepository { get; set; }
        public IFiliereRepository FiliereRepository { get; set; }
        public IFormateurRepository FormateurRepository { get; set; }
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
        Task<int> CompleteAsync();
    }
}
