using Application.Features.Rooms.Commands.Create;
using Application.Features.Rooms.Commands.Delete;
using Application.Features.Rooms.Commands.Update;
using Application.Features.Rooms.Queries.GetListOfRooms;
using Application.Features.Rooms.Queries.GetRoomById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRooms() {
            var query = new GetListOfRoomsQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("GetRoomById/{id:guid}")]
        public async Task<IActionResult> GetRoomById(Guid id) {
            var query = new GetRoomByIdQuery(id);
            var roomDto = await _mediator.Send(query);
            return Ok(roomDto);
        }

        [HttpPost]
        public async Task<string> CreateRoom([FromBody] AddNewRoomCommand command) {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom([FromBody] UpdateRoomCommand command) {


            var result = await _mediator.Send(command);
            if (result.Contains("successfully"))
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(Guid id) {
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

