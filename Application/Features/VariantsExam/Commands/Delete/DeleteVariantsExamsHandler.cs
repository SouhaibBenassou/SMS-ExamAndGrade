using Application.Features.Rooms.Commands.Delete;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.VariantsExam.Commands.Delete
{
    public class DeleteVariantsExamsHandler : IRequestHandler<DeleteVariantsExamsCommand, string>
    {
        private readonly IUnitOfService _unitOfService;

        public DeleteVariantsExamsHandler(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }

        public async Task<string> Handle(DeleteVariantsExamsCommand request, CancellationToken cancellationToken)
        {
            return await _unitOfService.VariantsExamService.DeleteVariantsExamAsync(request.VariantsExamId);
        }
    }
}
