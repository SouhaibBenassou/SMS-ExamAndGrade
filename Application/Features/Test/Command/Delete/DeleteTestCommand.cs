using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Test.Command.Delete
{
    public class DeleteTestCommand(Guid id) : IRequest<string>
    {
        public Guid TestId { get; set; } = id;
    }
}
