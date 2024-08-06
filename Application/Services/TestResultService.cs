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
}