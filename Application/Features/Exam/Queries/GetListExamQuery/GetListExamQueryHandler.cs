using Application.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Exam.Queries.GetListExamQuery
{
    public class GetListExamQueryHandler(IUnitOfService unitOfService, IMapper mapper) : IRequestHandler<GetListExamQuery, List<Domain.Entities.Exam>>
    {
        private readonly IUnitOfService _unitOfService = unitOfService;
        private readonly IMapper _mapper = mapper;
        public async Task<List<Domain.Entities.Exam>> Handle(GetListExamQuery request, CancellationToken cancellationToken) {
            List<Domain.Entities.Exam> exam = await _unitOfService.ExamService.GetListOfExamWithEntityAsync();
            return exam;
        }
    }
}
