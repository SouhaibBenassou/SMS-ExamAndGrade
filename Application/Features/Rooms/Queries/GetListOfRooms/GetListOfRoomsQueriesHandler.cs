using Application.Interfaces;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using MediatR;

namespace Application.Features.Rooms.Queries.GetListOfRooms
{
    public class GetListOfRoomsQueryHandler : IRequestHandler<GetListOfRoomsQuery, List<RoomDto>>
    {
        private readonly IUnitOfService _unitofService;
        private readonly IMapper _mapper;

        public GetListOfRoomsQueryHandler(IUnitOfService unitofService, IMapper mapper) {
            _unitofService = unitofService;
            _mapper = mapper;
        }

        public async Task<List<RoomDto>> Handle(GetListOfRoomsQuery request, CancellationToken cancellationToken) {

            List<Room> listRooms = await _unitofService.RoomService.GetListOfRoomsAsync();
            List<RoomDto> listRommDto = _mapper.Map<List<RoomDto>>(listRooms);
            return listRommDto;
        }
    }
}

