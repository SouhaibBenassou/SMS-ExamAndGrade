namespace Domain.Entities
{
    public class IndividualWork : AuditableEntity
    {
        public Guid StagiaireId { get; set; }
        public Stagiaire Stagiaire { get; set; }
        public ICollection<IndividualWorkUOF> individualWorkUOFs { get; set; }

    }
}
