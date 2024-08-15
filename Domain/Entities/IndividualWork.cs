namespace Domain.Entities
{
    public class IndividualWork : AuditableEntity
    {
        public Guid StagiaireId { get; set; }
        public int Note { get; set; }
        public Guid IndividualWorkUOFId { get; set; }
        public IndividualWorkUOF IndividualWorkUOF { get; set; }

    }
}
