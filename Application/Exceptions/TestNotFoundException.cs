namespace Application.Exceptions;

public class TestNotFoundException : Exception
{
    public TestNotFoundException() : base("Ce controle n'existe pas")
    {
    }
}