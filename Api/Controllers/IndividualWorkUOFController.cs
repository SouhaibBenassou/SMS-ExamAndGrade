using Application.Features.IndividualWorkUnitOfFormation.Command.Create;
using Application.Features.IndividualWorkUnitOfFormation.Command.Update;
using Application.Features.IndividualWorkUnitOfFormation.Queries.GetListIndividualWorkUOF;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/IndividualWorkUOF")]
    [ApiController]
    public class IndividualWorkUOFController : ControllerBase
    {

        private readonly IMediator _mediator;

        public IndividualWorkUOFController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateIndividualWorkUOF(AddIndividualWorkUOFCommand cmd) {
            var resutl = await _mediator.Send(cmd);
            return Ok(resutl);
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateIndividualWorkUOFCommand cmd) {
            try
            {
                var resutl = await _mediator.Send(cmd);
                return Ok(resutl);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllIndividualWorkUOF() {

            var res = await _mediator.Send(new GetListIndividualWorkUOFQuery());
            return Ok(res);
        }

    }
}
