using Domain;

namespace Application;

public interface ITestService
{

    Task<string> AddTestAsync(Test test);
    Task<string> UpdateTestAsync(Test test);
    Task<string> DeleteTestAsync(Guid Id);
    Task<List<Test>> GetListOfTestsAsync();
    Task<Test> GetTestByIdAsync(Guid Id);
}
