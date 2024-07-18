using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Exam.Command.Create
{
    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, string>
    {
        private readonly IUnitOfService _unitOfServie;
        private readonly IMapper _mapper;

        public CreateExamCommandHandler(IUnitOfService unitOfServie, IMapper mapper)
        {
            _unitOfServie = unitOfServie;
            _mapper = mapper;

        }


        public async Task<string> Handle(CreateExamCommand request, CancellationToken cancellationToken)
        {
            return await _unitOfServie.ExamService.AddExamAsync(_mapper.Map<Domain.Entities.Exam>(request));
        }
    }
}
