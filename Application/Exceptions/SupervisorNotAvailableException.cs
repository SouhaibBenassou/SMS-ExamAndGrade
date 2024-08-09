namespace Application.Exceptions;

public class SupervisorNotAvailableException : Exception
{
    public SupervisorNotAvailableException(string firstName,string lastName,DateTime start,DateTime end) : base($"La Superviseur {lastName} {firstName} n'est pas disponible entre {start} et {end}" )
    {
    }
}