using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;

namespace Application;

public class GetTestByIdQueryHandler : IRequestHandler<GetTestByIdQuery, TestDto>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;
    public GetTestByIdQueryHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<TestDto> Handle(GetTestByIdQuery request, CancellationToken cancellationToken)
    {
        Test Test = await _unitOfService.TestService.GetTestByIdAsync(request.TestId);
        return _mapper.Map<TestDto>(Test);
    }
}
