using Application.Interfaces;
using MediatR;

namespace Application.Features.Exam.Command.Create
{
    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, string>
    {
        private readonly IUnitOfService _unitOfServie;

        public CreateExamCommandHandler(IUnitOfService unitOfServie)
        {
            _unitOfServie = unitOfServie;
        }


        public async Task<string> Handle(CreateExamCommand request, CancellationToken cancellationToken)
        {

            var Exam = new Domain.Entities.Exam
            {

                YearId = request.YearId,
                SemesterId = request.SemesterId,

                FiliereId = request.FiliereId,
                UnitOfFormationId = request.UnitOfFormationId,
                RoomId = request.RoomId,
                SupervisorId = request.SupervisorId,
            };
            return await _unitOfServie.ExamService.AddExamAsync(Exam);
        }
    }
}
