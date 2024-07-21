using Application.Features.Exam.Command.Delete;
using Application.Features.Exam.Queries.GetListExamQuery;
using Application.Features.Test.Command.Create;
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

       
        [HttpPost]
        public async Task<string> CreateTest([FromForm] CreateTestCommand command)
        {
            return await _mediator.Send(command);
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
