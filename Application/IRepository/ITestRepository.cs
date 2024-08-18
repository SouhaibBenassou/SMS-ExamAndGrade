using System.Linq.Expressions;
using Application.IRepository;
using Domain;

namespace Application;

public interface ITestRepository : IAsyncRepository<Test>
{
    Task<Test> GetTestWithResults(Expression<Func<Test, bool>> filter = null);
    Task<List<Test>> GetAllTestWithResults(Expression<Func<Test, bool>> filter = null);
}
