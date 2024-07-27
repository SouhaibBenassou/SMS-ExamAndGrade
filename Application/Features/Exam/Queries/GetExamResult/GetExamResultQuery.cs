using Domain;
using MediatR;

namespace Application.Features.Exam.Queries.GetExamResult
{
    public class GetExamResultQuery(Guid id) : IRequest<ExamResultDto>
    {
        public Guid ExamId { get; set; } = id;
    }
}
