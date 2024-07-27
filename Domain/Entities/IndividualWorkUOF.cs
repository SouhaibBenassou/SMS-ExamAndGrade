namespace Domain.Entities
{
    public class IndividualWorkUOF : AuditableEntity
    {
        public string Name { get; set; }
        public int Confusion { get; set; }
        public int Note { get; set; }
        public Guid IndividualWorkId { get; set; }
        public IndividualWork IndividualWork { get; set; }
    }
}
