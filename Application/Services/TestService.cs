using Application.Interfaces;
using Domain;

namespace Application;

public class TestService : ITestService

{
    private readonly IUnitOfWork _unitOfWork;

    public TestService(IUnitOfWork unitOfWork) {
        _unitOfWork = unitOfWork;
    }

    public Task<string> AddTestAsync(Test test) {
        throw new NotImplementedException();
    }

    public Task<string> DeleteTestAsync(Guid Id) {
        throw new NotImplementedException();
    }

    public async Task<List<Test>> GetListOfTestsAsync() {
        List<Test> Test = await _unitOfWork.TestRepository.GetAllAsNoTracking();
        return Test;
    }

    public Task<Test> GetTestByIdAsync(Guid Id) {
        throw new NotImplementedException();
    }

    public Task<string> UpdateTestAsync(Test test) {
        throw new NotImplementedException();
    }
}
