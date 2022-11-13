using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Threenine;
using Threenine.ApiResponse;
using Namespace.Resource.Put;
using Namespace.Data;
namespace  Namespace.Activities.Resource.Commands.Put;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
    private readonly IDataService<Model> _services;

    public Handler(IDataService<Model> services)
    {
        _services = services;
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        return await _services.Update<DomainObject, Response>(x =>
            x.Id == request.Id, request.DomainObject);
    }
}
