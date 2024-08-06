namespace Application.IServices;

public interface IStagiereNoteService
{
    Task CheckIfStagiereHaveNoteInTest(Guid idTrainee, Guid idTest);
    Task CheckIfStagiereHaveNoteInExam(Guid idTrainee, Guid idExam);
}