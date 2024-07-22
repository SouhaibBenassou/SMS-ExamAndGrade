using Domain.Entities;

namespace Domain.Dtos.ExamDto
{
    public class GetListExamDto
    {
        public string? ExamDate { get; set; }
        public string? Duration { get; set; }
        public string? StartTime { get; set; }
        public ExamType? ExamType { get; set; }
        public Guid? YearId { get; set; }
        public YearDto? Year { get; set; }
        public YearType? YearType { get; set; }
        public Guid? FiliereId { get; set; }
        public Guid? UnitOfFormationId { get; set; }
        public Guid? RoomId { get; set; }
        public Guid? SupervisorId { get; set; }
    }
}
