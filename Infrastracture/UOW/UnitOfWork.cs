using Application;
using Application.Interfaces;
using Application.IRepository;
using Infrastructure.Data;

namespace Infrastracture.UOW;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    public IVariantsExamRepository VariantsExamRepository { get; set; }
    public ITestRepository TestRepository { get; set; }
    public ISupervisorRepository SupervisorRepository { get; set; }
    public IExamRepository ExamRepository { get; set; }
    public IRoomRepository RoomRepository { get; set; }
    public IExamResultRepository ExamResultRepository { get; set; }
    public ITestResultRepository TestResultRepository { get; set; }
    public IExamSessionRepository ExamSessionRepository { get; set; }
    public IIndividualWorkUOFRepository IndividualWorkUOFRepository { get; set; }
    public IFiliereRepository FiliereRepository { get; set; }
    public IFormateurRepository FormateurRepository { get; set; }

    public UnitOfWork(ApplicationDbContext db, IVariantsExamRepository variantsExamRepository, ITestRepository testRepository, ISupervisorRepository supervisorRepository, IExamRepository examRepository, IRoomRepository roomRepository, IExamResultRepository examResultRepository, ITestResultRepository testResultRepository, IExamSessionRepository examSessionRepository, IIndividualWorkUOFRepository individualWorkUofRepository, IFiliereRepository filiereRepository, IFormateurRepository formateurRepository)
    {
        _db = db;
        VariantsExamRepository = variantsExamRepository;
        TestRepository = testRepository;
        SupervisorRepository = supervisorRepository;
        ExamRepository = examRepository;
        RoomRepository = roomRepository;
        ExamResultRepository = examResultRepository;
        TestResultRepository = testResultRepository;
        ExamSessionRepository = examSessionRepository;
        IndividualWorkUOFRepository = individualWorkUofRepository;
        FiliereRepository = filiereRepository;
        FormateurRepository = formateurRepository;
    }

    public void Commit()
    {
        _db.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await _db.SaveChangesAsync();
    }

    public void Rollback()
    {
        _db.SaveChanges();
    }

    public async Task RollbackAsync()
    {
        await _db.SaveChangesAsync();
    }
    public async Task<int> CompleteAsync()
    {
        return await _db.SaveChangesAsync();
    }
}