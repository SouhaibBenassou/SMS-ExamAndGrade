using Domain.Entities;

namespace Domain.EntitiesFromOtherServices.FiliereService;

public class UnitOfFormation : FiliereBaseEntity
{
    
    public string Name { get; set; } = string.Empty;
    public string Semestre { get; set; }
    public int Duration { get; set; }
    public int Coefficient { get; set; }
    public ICollection<FiliereUnitOfFormation> FiliereUnitOfFormations { get; set; }
    public ICollection<Exam?>? Exams { get; set; }
    public ICollection<Test?>? Tests { get; set; }
    public ICollection<VariantsExams?>? VariantsExams { get; set; }
}