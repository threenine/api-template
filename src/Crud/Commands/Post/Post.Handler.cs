namespace Namespace.Resource.Commands.Post;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
    private readonly IDatabaseServices _services;

    public Handler(IDatabaseServices services)
    {
        _services = services;
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        return await _services.Create<Model, DTO, Response>(request.DTO);
    }
}
