namespace Application.Features.Results.Exceptions
{
    public class ExamNotFoundExceptions : Exception
    {
        public ExamNotFoundExceptions(Guid Id) : base($"Exam With this id:{Id} is notfound") {
        }
    }
}
