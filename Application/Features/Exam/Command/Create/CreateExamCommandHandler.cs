using Application.Exceptions;
using Application.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Exam.Command.Create
{
    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, string>
    {
        private readonly IUnitOfService _unitOfServie;
        private readonly IMapper _mapper;

        public CreateExamCommandHandler(IUnitOfService unitOfServie, IMapper mapper) {
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
                SupervisorId = request.SupervisorId,
            };
            exam.ExamSession = examSession;
            if(!await _unitOfServie.ExamSessionService.CheckRoomAvailability(examSession.StartTime,examSession.EndTime,examSession.RoomId))
            {
                Room room = await _unitOfServie.RoomService.GetRoomByIdAsync(request.RoomId); 
                throw new RoomNotAvailableException(room.RoomName, examSession.StartTime, examSession.EndTime);
            }
            if(!await _unitOfServie.ExamSessionService.CheckSupervisorAvailability(examSession.StartTime,examSession.EndTime,examSession.SupervisorId))
            {
                Domain.Entities.Supervisor supervisor =await _unitOfServie.SupervisorService.GetSupervisorById(request.SupervisorId);
                throw new SupervisorNotAvailableException(supervisor.FirstName, supervisor.LastName,
                    examSession.StartTime, examSession.EndTime);
            }
            
            return await _unitOfServie.ExamService.AddExamAsync(exam);
        }
    }
}
