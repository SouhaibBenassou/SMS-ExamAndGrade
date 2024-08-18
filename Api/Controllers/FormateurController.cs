using Application.Features.Formateur.Queries.GetListFormateurs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FormateurController : ControllerBase
{
    private readonly IMediator _mediator;

    public FormateurController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    [ResponseCache(CacheProfileName = "CacheProfile")]
    public async Task<IActionResult> GetAllFormateur()
    {
        return Ok(await _mediator.Send(new GetListFormateurs()));
    }
}