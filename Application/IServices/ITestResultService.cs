using Domain;
using Domain.Entities;

namespace Application.IServices;

public interface ITestResultService
{
    Task AddRangeTestResult(List<TestResult> testResults);
    Task<List<TestResult>> GetResultsByTest(Guid testId);
} 