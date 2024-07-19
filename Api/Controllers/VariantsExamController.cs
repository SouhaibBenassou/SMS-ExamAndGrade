using Microsoft.AspNetCore.Mvc;
using Application.Features.VariantsExams.Commands.Create;
using MediatR;
using Application.Features.VariantsExams.Queries.GetVariantsExamById;
using Application.Features.VariantsExam.Queries.GetAllVariantsExams;
using Application.Features.VariantsExam.Commands.Delete;
using Application.Features.VariantsExam.Commands.Update;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariantsExamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VariantsExamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetVariantsExamById/{id:guid}")]
        public async Task<IActionResult> GetVariantsExamById(Guid id)
        {
            var query = new GetVariantsExamByIdQuery(id);
            var variantsExamDto = await _mediator.Send(query);
            return Ok(variantsExamDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVariantsExams()
        {
            var query = new GetAllVariantsExamsQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPost]
        public async Task<string> CreateVariantsExam([FromForm] CreateVariantsExamCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVariantsExam([FromForm] UpdateVariantsExamCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVariantsExam(Guid id)
        {
            var command = new DeleteVariantsExamsCommand(id);
            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
    }
}
