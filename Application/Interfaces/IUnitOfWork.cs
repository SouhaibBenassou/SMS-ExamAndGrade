using Application.IRepository;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        public ISupervisorRepository SupervisorRepository { get; set; }
        public IExamRepository ExamRepository { get; set; }
        public IRoomRepository RoomRepository { get; set; }
        public ITestRepository TestRepository { get; set; }
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
        Task<int> CompleteAsync();
    }
}
