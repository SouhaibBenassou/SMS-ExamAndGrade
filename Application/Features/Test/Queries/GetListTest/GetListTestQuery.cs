using Domain.Dtos.TestDtos;
using MediatR;

namespace Application;

public class GetListTestQuery : IRequest<List<ListTestDtos>>
{

}
