using Application.IRepository;
using Domain;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastracture.Repositories;

public class TestResultRepository : AsyncRepository<TestResult>, ITestResultRepository
{
    public TestResultRepository(ApplicationDbContext db) : base(db)
    {
    }
}