using Application.Broker.Producers.Interafaces;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TraineeController : ControllerBase
{
    private readonly IListTraineeRequestProducer _listTraineeRequestProducer;
    private readonly ITraineeService _traineeService;

    public TraineeController(IListTraineeRequestProducer listTraineeRequestProducer, ITraineeService traineeService)
    {
        _listTraineeRequestProducer = listTraineeRequestProducer;
        _traineeService = traineeService;
    }

    [HttpGet]
    public async Task<IActionResult> Test()
    {
        await _listTraineeRequestProducer.ProduceAsync();
        return Ok(await _traineeService.GetAllTrainee());
    }
}