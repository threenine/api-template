using System.Threading;
using System.Threading.Tasks;

namespace Namespace.Resource.Commands.Patch;

[Route(Routes.Resource)]
public class Patch : EndpointBaseAsync.WithRequest<Command>.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public Patch(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPatch("{id:guid}")]
    [SwaggerOperation(
        Summary = "Patch",
        Description = "Patch",
        OperationId = "f564d830-2160-471c-b51b-bb878b229a15",
        Tags = new[] { Routes.Resource })
    ]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromBody] Command request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);
        
        return result.IsValid ? new OkObjectResult(result.Item) : new BadRequestObjectResult(result.Errors);
    }
}
