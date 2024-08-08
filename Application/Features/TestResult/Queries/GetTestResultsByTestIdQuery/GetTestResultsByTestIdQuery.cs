using Domain.Dtos.TestResultDto;
using MediatR;

namespace Application.Features.TestResult.Queries.GetTestResultsByTestIdQuery;

public class GetTestResultsByTestIdQuery : IRequest<List<TestResultDto>>
{
    public Guid TestId { get; set; }

    public GetTestResultsByTestIdQuery(Guid testId)
    {
        TestId = testId;
    }
}