using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;

namespace Application;

public class DeleteTestCommandHandler : IRequestHandler<DeleteTestCommand, string>
{
    private readonly IUnitOfService _unitOfService;

    public DeleteTestCommandHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;

    }
    public async Task<string> Handle(DeleteTestCommand request, CancellationToken cancellationToken)
    {
        

        return await _unitOfService.TestService.DeleteTestAsync(request.TestId);
    }
}
