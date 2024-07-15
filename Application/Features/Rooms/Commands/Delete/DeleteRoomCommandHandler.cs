using Application.Features.Rooms.Commands.Delete;
using Application.Interfaces;
using MediatR;

namespace Application.Features.Rooms.Handlers
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public DeleteRoomCommandHandler(IUnitOfService unitOfService) => _unitOfService = unitOfService;

        public async Task<string> Handle(DeleteRoomCommand request, CancellationToken cancellationToken) {
            return await _unitOfService.RoomService.DeleteRoomAsync(request.RoomId);
        }
    }
}
