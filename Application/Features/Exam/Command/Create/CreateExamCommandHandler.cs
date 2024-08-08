using Application.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Exam.Command.Create
{
    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, string>
    {
        private readonly IUnitOfService _unitOfServie;
        private readonly IMapper _mapper;

        public CreateExamCommandHandler(IUnitOfService unitOfServie, IMapper mapper)
        {
            _unitOfServie = unitOfServie;
            _mapper = mapper;

        }


        public async Task<string> Handle(CreateExamCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Exam exam = _mapper.Map<Domain.Entities.Exam>(request);
            ExamSession examSession = new ExamSession
            {
                StartTime = request.StartTime,
                EndTime = _unitOfServie.ExamSessionService.CalculateEndTime(request.StartTime,request.Duration),
                RoomId = request.RoomId,
            };
            exam.ExamSession = examSession;
            if(!await _unitOfServie.ExamSessionService.CheckRoomAvailability(examSession.StartTime,examSession.EndTime,examSession.RoomId))
            {
                Room room = await _unitOfServie.RoomService.GetRoomByIdAsync(request.RoomId); 
                throw new RoomNotAvailableException(room.RoomName, examSession.StartTime, examSession.EndTime);
            }
            
            return await _unitOfServie.ExamService.AddExamAsync(exam);
        }
    }
}
