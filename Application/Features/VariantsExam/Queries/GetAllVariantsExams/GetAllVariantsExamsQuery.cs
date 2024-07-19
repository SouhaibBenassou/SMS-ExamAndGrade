using Domain.Dtos;
using MediatR;

namespace Application.Features.VariantsExam.Queries.GetAllVariantsExams
{
    public class GetAllVariantsExamsQuery : IRequest<List<VariantsExamDto>>
    {
    }
}
