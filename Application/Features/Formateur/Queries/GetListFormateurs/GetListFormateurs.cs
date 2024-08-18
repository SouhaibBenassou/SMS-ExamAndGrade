using Domain.Dtos.FormateurDto;
using MediatR;

namespace Application.Features.Formateur.Queries.GetListFormateurs;

public class GetListFormateurs : IRequest<List<FormateurDto>>
{
    
}