using Application.Exceptions;
using Application.Interfaces;
using Application.IServices;
using Domain;
using Domain.Entities;

namespace Application.Services;

public class StagiereNoteService : IStagiereNoteService
{
    private readonly ITestService _testService;
    private readonly IExamService _examService;

    public StagiereNoteService(ITestService testService, IExamService examService)
    {
        _testService = testService;
        _examService = examService;
    }

    public async Task CheckIfStagiereHaveNoteInTest(Guid idTrainee, Guid idTest)
    {
        Test test = await _testService.GetTestByIdWithResults(idTest);
        if (test is null)
        {
            throw new TestNotFoundException();
        }
        List<TestResult> testResults = test.TestResults.ToList();
        if (testResults is null || !testResults.Any())
        {
            return;
        }
        foreach (TestResult tr in test.TestResults)
        {
            if (idTrainee == tr.StagiaireId)
            {
                throw new StagiereAlreadyHaveNoteException(idTrainee);
            }
        }
    }

    public Task CheckIfStagiereHaveNoteInExam(Guid idTrainee, Guid idExam)
    {
        throw new NotImplementedException();
    }
}