using Application.Interfaces;
using AutoMapper;
using Domain.Dtos;
using MediatR;

namespace Application.Features.VariantsExams.Queries.GetVariantsExamById
{
    public class GetVariantsExamByIdQueryHandler : IRequestHandler<GetVariantsExamByIdQuery, VariantsExamDto>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetVariantsExamByIdQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<VariantsExamDto> Handle(GetVariantsExamByIdQuery request, CancellationToken cancellationToken)
        {
            var variantsExam = await _unitOfService.VariantsExamService.GetVariantsExamAsync(request.VariantsExamId);
            var variantsExamDto = _mapper.Map<VariantsExamDto>(variantsExam);
            return variantsExamDto;
        }
    }
}
