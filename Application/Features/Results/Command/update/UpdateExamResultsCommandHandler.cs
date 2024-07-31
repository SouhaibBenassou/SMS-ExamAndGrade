using Application.Interfaces;
using AutoMapper;
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

            foreach (var item in request.StagiaireNoteDetails)
            {
                var existingNoteDetail = await _unitOfService.ExamResultsService.FindStagiereAsync(item.StagiaireId, request.ExamId);
                if (existingNoteDetail != null)
                {
                    _mapper.Map(item, existingNoteDetail);
                    await _unitOfService.ExamResultsService.UpdateStagiaireNotes(existingNoteDetail);

                }
            }
            return "ok";
        }
    }
}
