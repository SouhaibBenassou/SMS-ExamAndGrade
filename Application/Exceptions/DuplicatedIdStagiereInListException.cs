namespace Application.Exceptions;

public class DuplicatedIdStagiereInListException : Exception
{
    public DuplicatedIdStagiereInListException(Guid id ) : base($"le stagiere avec l'ID {id} a ete saisi deux fois ")
    {
    }
}