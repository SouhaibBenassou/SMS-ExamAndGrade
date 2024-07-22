

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
            var variantsExam = _unitOfService.VariantsExamService.GetVariantsExamAsync(request.Id);

            if (variantsExam == null)
            {
                return "VariantsExam not found";
            }

            var variantsExams = _mapper.Map<Domain.Entities.VariantsExams>(request);
            return await _unitOfService.VariantsExamService.UpdateVariantsExamAsync(variantsExams);
        }
    }
}
