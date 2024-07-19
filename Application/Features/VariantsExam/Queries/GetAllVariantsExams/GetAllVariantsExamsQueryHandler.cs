using Application.Features.VariantsExam.Queries.GetAllVariantsExams;
using Application.Interfaces;
using AutoMapper;
using Domain.Dtos;
using MediatR;

namespace Application.Features.VariantsExams.Queries.GetAllVariantsExams
{
    public class GetAllVariantsExamsQueryHandler : IRequestHandler<GetAllVariantsExamsQuery, List<VariantsExamDto>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetAllVariantsExamsQueryHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<List<VariantsExamDto>> Handle(GetAllVariantsExamsQuery request, CancellationToken cancellationToken)
        {
            var variantsExams = await _unitOfService.VariantsExamService.GetAllVariantsExamsAsync();
            var variantsExamsDto = _mapper.Map<List<VariantsExamDto>>(variantsExams);
            return variantsExamsDto;
        }
    }
}
