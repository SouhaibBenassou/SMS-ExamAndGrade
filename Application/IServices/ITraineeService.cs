using Domain.EntitiesFromOtherServices;

namespace Application.IServices;

public interface ITraineeService
{
    Task<List<Trainee>> GetAllTrainee();
    void ResetAndSetTraineeList(List<Trainee> trainees);
}