using Domain.Dtos.ExamDto;
using MediatR;

namespace Application.Features.Exam.Queries.GetListExamQuery
{
    public class GetListExamQuery : IRequest<List<GetListExamDto>>
    {
    }
}
