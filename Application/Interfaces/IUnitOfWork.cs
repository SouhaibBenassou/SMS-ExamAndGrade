using Application.IRepository;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IExamRepository ExamRepository { get; set; }
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
    }
}
