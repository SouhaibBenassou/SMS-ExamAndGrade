using MediatR;


namespace Application.Features.Supervisor.Queries
{
    public class GetAllSupervisorsQuery : IRequest<List<Domain.Entities.Supervisor>>
    {

    }
}
