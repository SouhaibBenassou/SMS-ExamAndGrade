using Application.Features.Exam.Command.Create;
using Application.Features.Exam.Command.Delete;
using Application.Features.Exam.Queries.GetListExamQuery;
using Application.Features.Exam.Queries.GetExamResult;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/Exam")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExamController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetListExam()
        {
            var res = await _mediator.Send(new GetListExamQuery());
            return Ok(res);
        }
        [HttpPost]
        public async Task<string> CreateExam([FromForm] CreateExamCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExam(Guid id)
        {
            var command = new DeleteExamCommand(id);
            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("ExamResult/{id}")]
        public async Task<IActionResult> GetExamResult(Guid id)
        {
            var query = new GetExamResultQuery(id);
            var Result = await _mediator.Send(query);
            return Ok(Result);
        }

    }
}
