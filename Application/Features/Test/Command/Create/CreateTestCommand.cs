using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Test.Command.Create
{
    public class CreateTestCommand : IRequest<string>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? TestStatement { get; set; }
        public string? TestCorrection { get; set; }
        public double? Note { get; set; }
        public Guid UnitOfFormationId { get; set; }
    }
}
