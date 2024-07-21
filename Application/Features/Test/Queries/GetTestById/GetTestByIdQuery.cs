using MediatR;

namespace Application;

public class GetTestByIdQuery(Guid id) : IRequest<string>
{

}
