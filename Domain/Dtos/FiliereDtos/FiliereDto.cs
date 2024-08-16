namespace Domain.Dtos.FiliereDto;

public class FiliereDto
{
    public Guid Id { get; set; }
    public string NomFiliere { get; set; }
    public string Description { get; set; }
    public int Duree { get; set; }
    public ICollection<FiliereUnitOfFormationDto.FiliereUnitOfFormationDto> FiliereUnitOfFormations { get; set; }
}