using Application.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Exam.Queries.GetListExamQuery
{
    public class GetListExamQueryHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<GetListExamQuery, List<Domain.Entities.Exam>>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;
        public async Task<List<Domain.Entities.Exam>> Handle(GetListExamQuery request, CancellationToken cancellationToken) {
            List<Domain.Entities.Exam> exam = await _uow.ExamRepository.GetAllWithRelatedEntities();
            return exam;
        }
    }
}
