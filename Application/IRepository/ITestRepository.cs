using Application.IRepository;
using Domain;

namespace Application;

public interface ITestRepository : IAsyncRepository<Test>
{
}
