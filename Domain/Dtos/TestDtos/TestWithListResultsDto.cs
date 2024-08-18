using Domain.Dtos.FiliereDto;
using Domain.Dtos.UnitOfFormationDto;

namespace Domain.Dtos.TestDtos;

public class TestWithListResultsDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? TestStatement { get; set; }
    public string? TestCorrection { get; set; }
    public Guid TrainerId { get; set; }
    public FiliereMinimaleDto Filiere { get; set; }
    public UnitOfFormationMinimaleDto? UnitOfFormation { get; set; }
    public List<TestResultDto.TestResultDto> TestResults { get; set; }
}