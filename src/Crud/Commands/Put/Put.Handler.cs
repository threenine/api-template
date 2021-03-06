using System.Threading;
using System.Threading.Tasks;
using Dtos;
using MediatR;
using Threenine;
using Threenine.ApiResponse;
using Dtos.DTOs.Put;

namespace  Namespace.Resource.Commands.Put;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
    private readonly IDataService _services;

    public Handler(IDataService services)
    {
        _services = services;
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        return await _services.Update<Model, DTO, Response>(x =>
            x.Id == request.Id, request.DTO);
    }
}
