using Domain.Entities;

namespace Domain.EntitiesFromOtherServices.FiliereService;

public class Filiere : FiliereBaseEntity
{
    public string NomFiliere { get; set; }
    public string Description { get; set; }
    public string Niveau { get; set; }
    public int Duree { get; set; }
    public int Capacite { get; set; }
    public int GroupCapacity { get; set; }
    public decimal FraisInscription { get; set; }
    public decimal MontantMensuel { get; set; }
    public decimal MontantAnnuel { get; set; }
    public decimal MontantTrimestre { get; set; }
    public ICollection<FiliereUnitOfFormation> FiliereUnitOfFormations { get; set; }
    public ICollection<Exam?>? Exams { get; set; }
}