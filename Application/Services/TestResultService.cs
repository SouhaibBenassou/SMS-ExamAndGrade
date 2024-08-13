using Application.Exceptions;
using Application.Interfaces;
using Application.IServices;
using Domain;
using Domain.Entities;

namespace Application.Services;

public class TestResultService : ITestResultService
{ 
    private readonly IUnitOfWork _unitOfWork;

    public TestResultService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task AddRangeTestResult(List<TestResult> testResults)
    {
        await _unitOfWork.TestResultRepository.CreateRangeAsync(testResults);
        await _unitOfWork.CommitAsync();
    }
    
    public async Task<List<TestResult>> GetResultsByTest(Guid testId)
    {
        Test test = await _unitOfWork.TestRepository.GetAsNoTracking(t => t.Id == testId) ??
                    throw new TestNotFoundException();
        return await _unitOfWork.TestResultRepository.GetAllAsNoTracking(tr => tr.TestId == testId);
    }
}