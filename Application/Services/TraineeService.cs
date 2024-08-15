using Application.Broker.Producers.Interafaces;
using Application.IServices;
using Domain.EntitiesFromOtherServices;

namespace Application.Services;

public class TraineeService : ITraineeService
{
    private List<Trainee> Trainees { get; set; }
    private TaskCompletionSource Loading = new();
    private readonly IListTraineeRequestProducer _listTraineeRequestProducer;

    public TraineeService(IListTraineeRequestProducer listTraineeRequestProducer)
    {
        _listTraineeRequestProducer = listTraineeRequestProducer;
    }

    public async Task<List<Trainee>> GetAllTrainee()
    {
        await _listTraineeRequestProducer.ProduceAsync();
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