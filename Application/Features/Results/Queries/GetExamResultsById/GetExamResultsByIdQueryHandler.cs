using Application.Interfaces;
using AutoMapper;
using Domain;
using Domain.Dtos.ResultsDto;
using MediatR;

namespace Application.Features.Results.Queries.GetExamResultsById
{
    public class GetExamResultsByIdQueryHandler : IRequestHandler<GetExamResultsByIdQuery, List<ListExamResutlsDto>>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public GetExamResultsByIdQueryHandler(IUnitOfService unitOfService, IMapper mapper) {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<List<ListExamResutlsDto>> Handle(GetExamResultsByIdQuery request, CancellationToken cancellationToken) {
            List<ExamResult> examResult = await _unitOfService.ExamResultsService.GetListExamResultByIdAsync(request.ExamID);
            if (examResult == null)
            {
                return null;
            }
            List<ListExamResutlsDto> getExamResutlsDto = _mapper.Map<List<ListExamResutlsDto>>(examResult);

            return getExamResutlsDto;
        }
    }
}
