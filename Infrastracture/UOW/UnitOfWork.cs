using Application;
using Application.Interfaces;
using Application.IRepository;
using Infrastructure.Data;


namespace Infrastracture;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    public IVariantsExamRepository VariantsExamRepository { get; set; }
    public ITestRepository TestRepository { get; set; }
    public ISupervisorRepository SupervisorRepository { get; set; }
    public IExamRepository ExamRepository { get; set; }
    public IRoomRepository RoomRepository { get; set; }
    public IExamResultRepository ExamResultRepository { get; set; }

    public UnitOfWork(ApplicationDbContext db, ISupervisorRepository supervisorRepository, IVariantsExamRepository variantsExamRepository, IExamRepository examRepository, IRoomRepository roomRepository, ITestRepository testRepository, IExamResultRepository examResultRepository) {
        _db = db;
        SupervisorRepository = supervisorRepository;
        ExamRepository = examRepository;
        RoomRepository = roomRepository;
        TestRepository = testRepository;
        VariantsExamRepository = variantsExamRepository;
        ExamResultRepository = examResultRepository;

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