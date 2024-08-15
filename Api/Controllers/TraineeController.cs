using Application.Broker.Producers.Interafaces;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TraineeController : ControllerBase
{
    private readonly ITraineeService _traineeService;

    public TraineeController(ITraineeService traineeService)
    {
        _traineeService = traineeService;
    }

    [HttpGet]
    public async Task<IActionResult> Test()
    {
        return Ok(await _traineeService.GetAllTrainee());
    }
}