using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;

namespace Application;

public class UpdateTestCommandHandler : IRequestHandler<UpdateTestCommand, string>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public UpdateTestCommandHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<string> Handle(UpdateTestCommand request, CancellationToken cancellationToken)
    {
        var test = _mapper.Map<Test>(request);
        return await _unitOfService.TestService.UpdateTestAsync(test);
    }
}
