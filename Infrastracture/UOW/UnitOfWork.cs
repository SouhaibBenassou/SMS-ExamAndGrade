
using Application.Interfaces;
using Application.IRepository;
using Infrastructure.Data;


namespace Infrastracture;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    public IExamRepository ExamRepository { get; set; }

    public UnitOfWork(ApplicationDbContext db, IExamRepository examRepository) {
        _db = db;
        ExamRepository = examRepository;
    }

    public void Commit() {
        _db.SaveChanges();
    }

    public async Task CommitAsync() {
        await _db.SaveChangesAsync();
    }

    public void Rollback() {
        _db.SaveChanges();
    }

    public async Task RollbackAsync() {
        await _db.SaveChangesAsync();
    }
}
