using Domain;

namespace Application;

public interface ITestService
{

    Task<string> AddTestAsync(Test test);
    Task<string> UpdateTestAsync(Test test);
    Task<string> DeleteTestAsync(Guid id);
    Task<List<Test>> GetListOfTestsAsync();
    Task<Test> GetTestByIdAsync(Guid Id);
    Task<Test> GetTestByIdWithResults(Guid id);
}
