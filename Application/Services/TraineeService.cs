using Application.IServices;
using Domain.EntitiesFromOtherServices;

namespace Application.Services;

public class TraineeService : ITraineeService
{
    private List<Trainee> Trainees { get; set; }
    public TaskCompletionSource Loading = new();
    
    public async Task<List<Trainee>> GetAllTrainee()
    {
        if (!Loading.Task.IsCompleted)
        {
            await Loading.Task;
        }

        ResetLoading();
        return Trainees;
    }

    public void ResetAndSetTraineeList(List<Trainee> trainees)
    {
        Trainees = new List<Trainee>();
        Trainees.AddRange(trainees);
        Loading.TrySetResult(); 
    }
    
    
    private void ResetLoading()
    {
        Loading = new TaskCompletionSource();
    }
    
    
}