namespace Domain.Dtos.ResultsDto
{
    public class StagiaireNoteDetailDto
    {
        public Guid StagiaireId { get; set; }
        public double? PracticalNote { get; set; }
        public double? TheoreticalNote { get; set; }
    }
}
