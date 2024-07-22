namespace Domain.Dtos.TestDtos
{
    public class ListTestDtos
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? TestStatement { get; set; }
        public string? TestCorrection { get; set; }
        public Guid TrainerId { get; set; }
        public Trainer? Trainer { get; set; }
        public Guid UnitOfFormationId { get; set; }
        public UnitOfFormation? UnitOfFormation { get; set; }
        public ICollection<TestResults>? TestResults { get; set; }
    }
}
