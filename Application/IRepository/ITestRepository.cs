using System.Linq.Expressions;
using Application.IRepository;
using Domain;

namespace Application;

public interface ITestRepository : IAsyncRepository<Test>
{
    public Task<Test> GetTestWithResults(Expression<Func<Test, bool>> filter = null);
}
