namespace Domain.Dtos.FiliereUnitOfFormationDto;

public class FiliereUnitOfFormationDto
{
    public Guid FiliereId { get; set; }
    public Guid UnitOfFormationId { get; set; }
    public UnitOfFormationDto.UnitOfFormationDto UnitOfFormation { get; set; }
}