using MediatR;



namespace Application.Features.Supervisor.command.Create
{
    public class CreateSupervisorCommand : IRequest<string>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}