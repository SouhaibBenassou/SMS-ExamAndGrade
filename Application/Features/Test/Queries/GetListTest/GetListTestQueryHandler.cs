using Application.Interfaces;
using AutoMapper;
using Domain;
using Domain.Dtos.TestDtos;
using MediatR;

namespace Application;

public class GetListTestQueryHandler : IRequestHandler<GetListTestQuery, List<ListTestDtos>>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public GetListTestQueryHandler(IUnitOfService unitOfService, IMapper mapper) {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<List<ListTestDtos>> Handle(GetListTestQuery request, CancellationToken cancellationToken) {
        List<Test> testList = await _unitOfService.TestService.GetListOfTestsAsync();
        List<ListTestDtos> testlistdto = _mapper.Map<List<ListTestDtos>>(testList);
        return testlistdto;
    }
}
