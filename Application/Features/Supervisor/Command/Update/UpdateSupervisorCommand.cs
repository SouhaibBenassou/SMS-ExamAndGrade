using MediatR;
using System;


namespace Application.Features.Supervisor.Commands.Update
{
    public class UpdateSupervisorCommand : IRequest<string>
    {
      
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}
