using Application.Features.Filiere.Queries.GetListFiliereQuery;
using Application.Features.Filiere.Queries.GetOneFiliereQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FiliereController : ControllerBase
{
    private readonly IMediator _mediator;

    public FiliereController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllFiliere()
    {
        return Ok(await _mediator.Send(new GetListFiliereQuery()));
    }
    [HttpGet("{filiereId}")]
    public async Task<IActionResult> GetOneFiliere(Guid filiereId)
    {
        return Ok(await _mediator.Send(new GetOneFiliereQuery(filiereId)));
    }
}