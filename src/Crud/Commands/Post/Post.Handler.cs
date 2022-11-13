using MediatR;
using Threenine;
using Threenine.ApiResponse;
using Namespace.Resource.Post;
using Namespace.Data;
namespace Namespace.Activities.Resource.Commands.Post;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
    private readonly IDataService<Model> _services;

    public Handler(IDataService<Model> services)
    {
        _services = services;
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        return await _services.Create<DomainObject, Response>(request.DomainObject);
    }
}
