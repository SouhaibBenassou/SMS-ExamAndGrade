namespace Domain.Entities
{
    public class IndividualWorkUOF : AuditableEntity
    {
        public string? Name { get; set; }
        public int? Confusion { get; set; }
        public ICollection<IndividualWork>? IndividualWork { get; set; }
    }
}
