namespace Application.Exceptions;

public class ExamNotFoundException : Exception
{
    public ExamNotFoundException() : base("Cet examen n'existe pas")
    {
    }
}