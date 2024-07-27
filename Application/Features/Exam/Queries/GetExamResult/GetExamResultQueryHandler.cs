
using Application.Features.Exam.Queries.GetExamResult;
using Application.Interfaces;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;

namespace Application;

public class GetExamResultQueryHandler : IRequestHandler<GetExamResultQuery, ExamResultDto>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public GetExamResultQueryHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }
    public async Task<ExamResultDto> Handle(GetExamResultQuery request, CancellationToken cancellationToken)
    {
        Exam examResult = await _unitOfService.ExamService.GetExamByIdAsync(request.ExamId);
        if (examResult == null)
        {
            return null;
        }
        ExamResultDto examResultDto = _mapper.Map<ExamResultDto>(examResult);
        return examResultDto;
    }
}
