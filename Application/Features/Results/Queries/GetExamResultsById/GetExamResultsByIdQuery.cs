using Domain.Dtos.ResultsDto;
using MediatR;

namespace Application.Features.Results.Queries.GetExamResultsById
{
    public class GetExamResultsByIdQuery(Guid id) : IRequest<List<ListExamResutlsDto>>
    {
        public Guid ExamID { get; set; } = id;
    }
}
