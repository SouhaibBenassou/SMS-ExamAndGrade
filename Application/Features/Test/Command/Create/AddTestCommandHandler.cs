using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;

namespace Application;

public class AddTestCommandHandler : IRequestHandler<AddTestCommand, string>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public AddTestCommandHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }
    public async Task<string> Handle(AddTestCommand request, CancellationToken cancellationToken)
    {
        var test = _mapper.Map<Test>(request);
        return await _unitOfService.TestService.AddTestAsync(test);
    }
}
