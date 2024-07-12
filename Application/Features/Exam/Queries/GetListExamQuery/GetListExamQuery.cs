using MediatR;

namespace Application.Features.Exam.Queries.GetListExamQuery
{
    public class GetListExamQuery : IRequest<List<Domain.Entities.Exam>>
    {
    }
}
