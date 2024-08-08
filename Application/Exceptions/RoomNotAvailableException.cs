namespace Application.Exceptions;

public class RoomNotAvailableException : Exception
{
    public RoomNotAvailableException(string roomName,DateTime start,DateTime end) : base($"La salle {roomName} n'est pas disponible entre {start} et {end}" )
    {
    }
}