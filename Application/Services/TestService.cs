using Application.Interfaces;
using Domain;
 
namespace Application;

public class TestService : ITestService
{
    private readonly IUnitOfWork _unitOfWork;

    public TestService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<string> AddTestAsync(Test test)
    {
        await _unitOfWork.TestRepository.CreateAsync(test);
        await _unitOfWork.CommitAsync();
        return "Test created successfully";
    }

    public async Task<string> DeleteTestAsync(Guid id)
    {
        var test = await _unitOfWork.TestRepository.GetAsNoTracking(r => r.Id == id);
        if (test == null)
        {
            return $"Test with Id : {id} not found.";
        }
        await _unitOfWork.TestRepository.RemoveAsync(test);
        await _unitOfWork.CommitAsync();
        return "Test deleted successfully";
    }

    public async Task<List<Test>> GetListOfTestsAsync()
    {
        List<Test> Test = await _unitOfWork.TestRepository.GetAllAsNoTracking();
        return Test;
    }

    public async Task<Test> GetTestByIdAsync(Guid Id)
    {
        Test test = await _unitOfWork.TestRepository.GetAsNoTracking(r => r.Id == Id);
        if (test == null)
        {
            return null;
        }

        return test;
    }

    public async Task<string> UpdateTestAsync(Test test)
    {
        var existingTest = await _unitOfWork.TestRepository.GetAsNoTracking(r => r.Id == test.Id);
        if (existingTest == null)
        {
            return $"Test with Id : {test.Id} not found.";
        }

        await _unitOfWork.TestRepository.UpdateAsync(test);
        await _unitOfWork.CommitAsync();

        return "Test updated successfully";
    }

    public async Task<Test> GetTestByIdWithResults(Guid id)
    {
        Test test = await _unitOfWork.TestRepository.GetTestWithResults(t => t.Id == id);
        return test;
    }
}
