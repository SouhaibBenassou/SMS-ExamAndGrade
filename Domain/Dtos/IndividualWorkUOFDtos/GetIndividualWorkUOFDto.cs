using Domain.Entities;

namespace Domain.Dtos.IndividualWorkUOFDtos
{
    public class GetIndividualWorkUOFDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Confusion { get; set; }
        public ICollection<IndividualWork>? individualWork { get; set; }
    }
}
