using Domain.Entities;

namespace Domain
{
    public class Stagiaire : AuditableEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CIN { get; set; }
        public ICollection<TestResults>? TestResults { get; set; }
        public ICollection<ExamAttendance>? ExamAttendances { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }
        public ICollection<IndividualWork>? IndividualWorks { get; set; }
    }
}
