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

    
    public async Task<TestResult> GetOneTestResult(Guid id)
    {
        return await _unitOfWork.TestResultRepository.GetAsTracking(tr => tr.Id == id);
    }
    
    public async Task DeleteOneTestResult(Guid id)
    {
        TestResult testResult = await GetOneTestResult(id);
        await _unitOfWork.TestResultRepository.RemoveAsync(testResult);
        await _unitOfWork.CommitAsync();
    }
    public async Task DeleteTestResultOfTest(Guid testId)
    {
        List<TestResult> testResults = await GetResultsByTest(testId);
        foreach (TestResult tr in testResults)
        {
            await _unitOfWork.TestResultRepository.RemoveAsync(tr);
        }
        await _unitOfWork.CommitAsync();
    }
}