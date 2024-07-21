using Application.Features.Exam.Command.Create;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Test.Command.Create
{
    public class CreateTestCommandHandler : IRequestHandler<CreateTestCommand, string>
    {
        private readonly IUnitOfService _unitOfServie;

        public CreateTestCommandHandler(IUnitOfService unitOfServie)
        {
            _unitOfServie = unitOfServie;
        }


        public async Task<string> Handle(CreateTestCommand request, CancellationToken cancellationToken)
        {

            var test = new Domain.Entities.Test
            {

                Name = request.Name,
                Description = request.Description,

                TestStatement = request.TestStatement,
                UnitOfFormationId = request.UnitOfFormationId,
                TestCorrection = request.TestCorrection,
                Note = request.Note,
            };
            return await _unitOfServie.TestService.AddTestAsync(test);
        }
    }
}

