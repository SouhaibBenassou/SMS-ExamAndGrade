namespace Domain.Entities
{
    public class YearOfStudy : AuditableEntity
    {
        public string Year { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
