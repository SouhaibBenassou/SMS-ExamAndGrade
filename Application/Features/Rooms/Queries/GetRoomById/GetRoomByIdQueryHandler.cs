using Application.Interfaces;
using AutoMapper;
using Domain.Dtos;
using MediatR;

namespace Application.Features.Rooms.Queries.GetRoomById
{
    public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomDto>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetRoomByIdQueryHandler(IUnitOfService unitOfService, IMapper mapper) {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<RoomDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken) {
            var room = await _unitOfService.RoomService.GetRoomByIdAsync(request.RoomId);
            var roomDto = _mapper.Map<RoomDto>(room);
            return roomDto;
        }
    }
}
