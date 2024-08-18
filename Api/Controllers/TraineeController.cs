using Application.Broker.Producers.Interafaces;
using Application.Features.Trainee.Queries.GetListTraineeByFiliere;
using Application.Features.Trainee.Queries.GetListTraineeQuery;
using Application.IServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TraineeController : ControllerBase
{
    private readonly IMediator _mediator;

    public TraineeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTrainees()
    {
        return Ok(await _mediator.Send(new GetListTraineeQuery()));
    }
    
    [HttpGet("{filiereId}")]
    public async Task<IActionResult> GetAllTraineesInFiliere(Guid filiereId)
    {
        return Ok(await _mediator.Send(new GetListTraineeByFiliereQuery(filiereId)));
    }
}