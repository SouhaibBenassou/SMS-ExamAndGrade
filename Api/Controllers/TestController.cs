using Application;
using Application.Features.Rooms.Commands.Delete;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTests() {
            var query = new GetListTestQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetTestById(Guid id) {
            var query = new GetTestByIdQuery(id);
            var roomDto = await _mediator.Send(query);
            return Ok(roomDto);
        }

        [HttpPost]
        public async Task<string> CreateTest([FromForm] AddTestCommand command) {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTest([FromForm] UpdateTestCommand command) {
            var result = await _mediator.Send(command);
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTest(Guid id) {
            var command = new DeleteRoomCommand(id);
            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


    }
}
