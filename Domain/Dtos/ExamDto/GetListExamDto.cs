namespace Domain.Dtos.ExamDto
{
    public class GetListExamDto
    {
        public int ExamId { get; set; }
        public DateTime ExamDate { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan StartTime { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string FiliereName { get; set; }
        public string UnitName { get; set; }
        public string RoomName { get; set; }
        public string SupervisorName { get; set; }
    }
}
