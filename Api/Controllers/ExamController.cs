using Application.Features.Exam.Queries.GetListExamQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/Exam")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExamController(IMediator mediator) {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetListExam() {
            var res = await _mediator.Send(new GetListExamQuery());
            return Ok(res);
        }

    }
}
