using Application.IRepository;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IExamRepository ExamRepository { get; set; }
        public IRoomRepository RoomRepository { get; }
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
        Task<int> CompleteAsync();
    }
}
