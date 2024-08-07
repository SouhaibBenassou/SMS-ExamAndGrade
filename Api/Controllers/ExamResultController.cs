using Application.Features.Results.Command.Create;
using Application.Features.Results.Command.update;
using Application.Features.Results.Queries.GetExamResultsById;
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
        public async Task<IActionResult> UpdateVariantsExam([FromBody] UpdateExamResultsCommand command) {
            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost]
        public async Task<IActionResult> CreateExamResult([FromBody] AddExamResultsCommand command) {
            try
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetExamResults(Guid id) {
            var result = await _mediator.Send(new GetExamResultsByIdQuery(id));
            return Ok(result);
        }

    }
}

