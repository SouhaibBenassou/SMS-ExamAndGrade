namespace Domain.Entities
{
    public class IndividualWork : AuditableEntity
    {
        public Guid StagiaireId { get; set; }
        public ICollection<IndividualWorkUOF>? individualWorkUOFs { get; set; }

    }
}
