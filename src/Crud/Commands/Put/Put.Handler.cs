using System.Threading;
using System.Threading.Tasks;

namespace  Namespace.Resource.Commands.Put;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
    private readonly IDatabaseServices _services;

    public Handler(IDatabaseServices services)
    {
        _services = services;
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        return await _services.Update<Model, DTO, Response>(x =>
            x.Id == request.Id, request.DTO);
    }
}