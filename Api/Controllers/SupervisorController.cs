using Application.Features.Supervisor.command.Create;
using Application.Features.Supervisor.Commands.Delete;
using Application.Features.Supervisor.Commands.Update;
using Application.Features.Supervisor.Queries;
using Application.IServices;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupervisorController : ControllerBase
    {
        private readonly ISupervisorService _supervisorService;
        private readonly IMediator _mediator;

        public SupervisorController(ISupervisorService supervisorService, IMediator mediator) {
            _supervisorService = supervisorService;
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllSupervisors() {
            var query = new GetAllSupervisorsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("id/{supervisorId}")]
        public async Task<IActionResult> GetSupervisorById(Guid supervisorId) {
            var query = new GetSupervisorByIdQuery(supervisorId);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSupervisor([FromForm] CreateSupervisorCommand cmd) {

            var result = await _mediator.Send(cmd);
            return Ok(result);
        }

        [HttpPut("{supervisorId}")]
        public async Task<IActionResult> UpdateSupervisor(Guid supervisorId, [FromBody] Supervisor supervisorDto) {
            if (supervisorId != supervisorDto.Id)
            {
                return BadRequest("Supervisor ID mismatch");
            }

            var command = new UpdateSupervisorCommand(supervisorDto);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{supervisorId}")]
        public async Task<IActionResult> DeleteSupervisor(Guid supervisorId) {
            var command = new DeleteSupervisorCommand(supervisorId);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}