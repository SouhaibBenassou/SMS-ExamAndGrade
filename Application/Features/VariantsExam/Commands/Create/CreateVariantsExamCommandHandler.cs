using Application.Features.VariantsExams.Commands.Create;
using Application.Interfaces;
using Domain.Dtos;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.VariantsExams.Handlers
{
    public class CreateVariantsExamCommandHandler : IRequestHandler<CreateVariantsExamCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public CreateVariantsExamCommandHandler(IUnitOfService unitOfService) => _unitOfService = unitOfService;

        public async Task<string> Handle(CreateVariantsExamCommand request, CancellationToken cancellationToken)
        {
            var variantsExamsDto = new VariantsExamDto
            {
                ExamId = request.ExamId,
                Description = request.Description,
                VariantName = request.VariantName,
                ExamStatement = request.ExamStatement,
                ExamCorrection = request.ExamCorrection,
                VariantType = request.VariantType,
                NoteMax = request.NoteMax,
                IsValid = request.IsValid ?? false,
                TrainerId = request.TrainerId
            };

            return await _unitOfService.VariantsExamService.AddVariantsExamAsync(variantsExamsDto);
        }
    }
}
