using Application.Interfaces;
using Application.IServices;
using Application.IRepository;
using Domain.Entities;
using Domain.Dtos;
using AutoMapper;

namespace Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IUnitOfWork unitOfWork, IRoomRepository roomRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public async Task<string> AddRoomAsync(Room room)
        {
            await _unitOfWork.RoomRepository.AddAsync(room);
            await _unitOfWork.CompleteAsync();
            return "Room successfully added.";
        }

        public async Task<string> UpdateRoomAsync(Room room)
        {
            var existingRoom = await _unitOfWork.RoomRepository.GetByIdAsync(room.Id);
            if (existingRoom == null)
            {
                return $"Room with Id {room.Id} not found.";
            }

            existingRoom.Capacity = room.Capacity;
            existingRoom.RoomType = room.RoomType;

            _unitOfWork.RoomRepository.Update(existingRoom);
            await _unitOfWork.CompleteAsync();

            return "Room successfully updated.";
        }

        public async Task<string> DeleteRoomAsync(Guid roomId)
        {
            var room = await _unitOfWork.RoomRepository.GetByIdAsync(roomId);
            if (room == null)
            {
                return $"Room with Id {roomId} not found.";
            }

            _unitOfWork.RoomRepository.Delete(room);
            await _unitOfWork.CompleteAsync();

            return "Room successfully deleted.";
        }

        public async Task<IEnumerable<RoomDto>> GetListOfRoomsAsync()
        {
            var rooms = await _roomRepository.FindAllAsync();
            return rooms.Select(r => _mapper.Map<RoomDto>(r));
        }

        public async Task<RoomDto> GetRoomByIdAsync(Guid roomId)
        {
            var room = await _unitOfWork.RoomRepository.GetByIdAsync(roomId);
            if (room == null)
            {
                return null;
            }

            return _mapper.Map<RoomDto>(room);
        }
    }
}
