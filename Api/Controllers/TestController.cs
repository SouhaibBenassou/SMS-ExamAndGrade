using Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTests()
        {
            var query = new GetListTestQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetTestById(Guid id)
        {
            var query = new GetTestByIdQuery(id);
            var Test = await _mediator.Send(query);
            return Ok(Test);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTest([FromBody] AddTestCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateTest(Guid id, [FromBody] UpdateTestCommand command)
        {
            command.Id = id;

            var result = await _mediator.Send(command);
            if (result == null)
            {
                return NotFound($"Test with Id : {id} not found.");
            }

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTest(Guid id)
        {
            var command = new DeleteTestCommand(id);
            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
