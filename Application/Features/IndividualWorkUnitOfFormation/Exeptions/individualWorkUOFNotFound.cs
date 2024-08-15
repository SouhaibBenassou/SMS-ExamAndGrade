namespace Application.Features.IndividualWorkUnitOfFormation.Exeptions
{
    public class individualWorkUOFNotFound : Exception
    {
        public individualWorkUOFNotFound(Guid id) : base($"individualWorkUOF NotFound with this id {id}") {
        }
    }
}
