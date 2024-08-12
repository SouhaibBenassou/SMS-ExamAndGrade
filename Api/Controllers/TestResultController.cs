using Application.Features.TestResult.Command.Create;
using Application.Features.TestResult.Queries.GetTestResultsByTestIdQuery;
using Domain;
using Domain.Dtos.TestDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestResultController : ControllerBase
{
    private readonly IMediator _mediator;

    public TestResultController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateTestResults([FromBody] CreateTestResultCommand createTestResultCommand)
    {
        try
        {
            TestWithListResultsDto testWithListResultsDto = await _mediator.Send(createTestResultCommand);
            return Ok(testWithListResultsDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTestResults(Guid id) {
        try
        {
            return Ok(await _mediator.Send(new GetTestResultsByTestIdQuery(id)));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}