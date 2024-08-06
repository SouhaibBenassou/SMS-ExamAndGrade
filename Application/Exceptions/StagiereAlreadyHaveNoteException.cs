namespace Application.Exceptions;

public class StagiereAlreadyHaveNoteException : Exception
{
    public StagiereAlreadyHaveNoteException(Guid id) : base($"le Stagiere qui y'a l'Id : {id} a deja une note")
    {
    }
}