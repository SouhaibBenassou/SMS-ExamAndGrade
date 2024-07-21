using Application.Features.Exam.Command.Delete;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Test.Command.Delete
{
    internal class DeleteTestCommandHandler : IRequestHandler<DeleteTestCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public DeleteTestCommandHandler(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }

        public Task<string> Handle(DeleteTestCommand request, CancellationToken cancellationToken)
        {
            return _unitOfService.TestService.DeleteTestAsync(request.TestId);
        }
    }
}
