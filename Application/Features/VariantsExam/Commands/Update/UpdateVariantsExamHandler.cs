

using Application.Interfaces;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using MediatR;

namespace Application.Features.VariantsExam.Commands.Update
{
    public class UpdateVariantsExamHandler : IRequestHandler<UpdateVariantsExamCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public UpdateVariantsExamHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateVariantsExamCommand request, CancellationToken cancellationToken)
        {
            VariantsExamDto updateVariantsExam = new VariantsExamDto
            {
                
                Description = request.Description,
                ExamId = request.ExamId,
                TrainerId = request.TrainerId,
                VariantName = request.VariantName,
                VariantType = request.VariantType,
                ExamStatement = request.ExamStatement,
                ExamCorrection = request.ExamCorrection,
                IsValid = (bool)request.IsValid
            };

            return await _unitOfService.VariantsExamService.UpdateVariantsExamAsync(updateVariantsExam);
        }
    }
}
