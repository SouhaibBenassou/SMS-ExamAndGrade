using Application.Broker.Producers.Interafaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TraineeController : ControllerBase
{
    private readonly IListTraineeRequestProducer _listTraineeRequestProducer;

    public TraineeController(IListTraineeRequestProducer listTraineeRequestProducer)
    {
        _listTraineeRequestProducer = listTraineeRequestProducer;
    }

    [HttpGet]
    public async Task<IActionResult> Test()
    {
        await _listTraineeRequestProducer.ProduceAsync();
        return Ok();
    }
}