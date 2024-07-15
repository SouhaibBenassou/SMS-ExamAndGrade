
using Application.Interfaces;
using Application.IRepository;
using Infrastructure.Data;


namespace Infrastracture;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    public ISupervisorRepository SupervisorRepository { get; set; }
    public IExamRepository ExamRepository { get; set; }
    public IRoomRepository RoomRepository { get; set; }

    public UnitOfWork(ApplicationDbContext db, ISupervisorRepository supervisorRepository, IExamRepository examRepository, IRoomRepository roomRepository) {
        _db = db;
        SupervisorRepository = supervisorRepository;
        ExamRepository = examRepository;
        RoomRepository = roomRepository;
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
    public async Task<int> CompleteAsync() {
        return await _db.SaveChangesAsync();
    }
}
