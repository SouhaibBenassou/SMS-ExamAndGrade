using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.VariantsExam.Commands.Delete
{
    public class DeleteVariantsExamsCommand(Guid id) : IRequest<string>
    {
        public Guid VariantsExamId { get; set; } = id;

    }
}
