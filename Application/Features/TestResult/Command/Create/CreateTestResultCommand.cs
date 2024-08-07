using Domain.Dtos.TestDtos;
using Domain.Dtos.TestResultDto;
using MediatR;

namespace Application.Features.TestResult.Command.Create;

public class CreateTestResultCommand : IRequest<TestWithListResultsDto>
{
    public Guid TestId { get; set; }
    public List<StagiaireTestNoteDetailDto> StagiaireTestNoteDetails { get; set; }
}