using Domain;
using Domain.Entities;

namespace Application.IServices;

public interface ITestResultService
{
    public Task AddRangeTestResult(List<TestResult> testResults);
}