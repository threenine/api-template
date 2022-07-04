using Dtos;
using MediatR;
using Threenine;
using Threenine.ApiResponse;
using Dtos.DTOs.Post;

namespace Namespace.Resource.Commands.Post;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
    private readonly IDataService _services;

    public Handler(IDataService services)
    {
        _services = services;
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        return await _services.Create<Model, DTO, Response>(request.DTO);
    }
}
