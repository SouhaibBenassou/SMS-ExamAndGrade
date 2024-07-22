using Domain;
using MediatR;

namespace Application;

public class GetTestByIdQuery(Guid id) : IRequest<TestDto>
{
    public Guid TestId { get; set; } = id;

}
