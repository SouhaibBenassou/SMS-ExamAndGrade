using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Results.Command.update
{
    public class UpdateExamResultsCommandHandler : IRequestHandler<UpdateExamResultsCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public UpdateExamResultsCommandHandler(IUnitOfService unitOfService, IMapper mapper) {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateExamResultsCommand request, CancellationToken cancellationToken) {
            ExamResult examResult = await _unitOfService.ExamResultsService.GetExamResultByIdAsync(request.ExamResutlId);
            if (examResult == null)
            {
                return "NotFound";
            }
            var updateExam = _mapper.Map<ExamResult>(request);
            await _unitOfService.ExamResultsService.UpdateExamResultAsync(updateExam);
            return "ok";
        }
    }
}
