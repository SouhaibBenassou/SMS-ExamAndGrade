using Domain;
using Domain.Entities;

namespace Application.IServices;

public interface ITestResultService
{
    Task AddRangeTestResult(List<TestResult> testResults);
    Task<List<TestResult>> GetResultsByTest(Guid testId);
    Task DeleteOneTestResult(Guid id);
    Task DeleteTestResultOfTest(Guid testId);
} 