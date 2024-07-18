using Application.Interfaces;
using Application.IServices;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoomService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> AddRoomAsync(Room room)
        {
            await _unitOfWork.RoomRepository.CreateAsync(room);
            await _unitOfWork.CompleteAsync();
            return "Room successfully added.";
        }

        public async Task<string> UpdateRoomAsync(Room room)
        {
            var existingRoom = await _unitOfWork.RoomRepository.GetAsNoTracking(r => r.Id == room.Id);
            if (existingRoom == null)
            {
                return $"Room with Id {room.Id} not found.";
            }

            existingRoom.Capacity = room.Capacity;
            existingRoom.RoomType = room.RoomType;
            existingRoom.RoomName = room.RoomName;

            await _unitOfWork.RoomRepository.UpdateAsync(existingRoom);
            await _unitOfWork.CompleteAsync();

            return "Room successfully updated.";
        }

        public async Task<string> DeleteRoomAsync(Guid id)
        {
            var room = await _unitOfWork.RoomRepository.GetAsNoTracking(r => r.Id == id);
            if (room == null)
            {
                return $"Room with Id : {id} not found.";
            }

            await _unitOfWork.RoomRepository.RemoveAsync(room);
            await _unitOfWork.CompleteAsync();

            return "Room successfully deleted.";
        }

        public async Task<List<Room>> GetListOfRoomsAsync()
        {
            var rooms = await _unitOfWork.RoomRepository.GetAllAsNoTracking();
            return rooms;
        }

        public async Task<Room> GetRoomByIdAsync(Guid Id)
        {
            var room = await _unitOfWork.RoomRepository.GetAsNoTracking(r => r.Id == Id);
            if (room == null)
            {
                return null;
            }

            return room;
        }
    }
}
