using Application.Features.Results.Command.update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/ExamResult")]
    [ApiController]
    public class ExamResultController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExamResultController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVariantsExam([FromForm] UpdateExamResultsCommand command) {
            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
