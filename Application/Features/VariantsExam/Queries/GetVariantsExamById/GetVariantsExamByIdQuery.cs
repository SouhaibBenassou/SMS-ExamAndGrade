using MediatR;
using Domain.Entities;
using Domain.Dtos;

namespace Application.Features.VariantsExams.Queries.GetVariantsExamById
{
    public class GetVariantsExamByIdQuery(Guid id) : IRequest<VariantsExamDto>
    {
        public Guid VariantsExamId { get; set; } = id;
    }
}
