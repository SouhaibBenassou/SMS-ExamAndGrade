using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.ExamDto;
using MediatR;

namespace Application.Features.Exam.Queries.GetListExamQuery
{
    public class GetListExamQueryHandler(IUnitOfService unitOfService, IMapper mapper) : IRequestHandler<GetListExamQuery, List<GetListExamDto>>
    {
        private readonly IUnitOfService _unitOfService = unitOfService;

        public async Task<List<GetListExamDto>> Handle(GetListExamQuery request, CancellationToken cancellationToken)
        {
            List<Domain.Entities.Exam> exam = await _unitOfService.ExamService.GetListOfExamWithEntityAsync();

            List<GetListExamDto> ListExamDto = mapper.Map<List<GetListExamDto>>(exam);
            return ListExamDto;
        }
    }
}
