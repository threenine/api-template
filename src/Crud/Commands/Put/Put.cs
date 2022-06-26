using System.Threading;
using System.Threading.Tasks;

namespace  Namespace.Resource.Commands.Put;

[Route(Routes.Resource)]
public class Put : EndpointBaseAsync.WithRequest<Command>.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public Put(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPut("{id:guid}")]
    [SwaggerOperation(
        Summary = "Put",
        Description = "Put",
        OperationId = "d4ea45d8-8e78-4d4c-b4b1-f7ee72679ce9",
        Tags = new[] { Routes.Resource })
    ]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromBody] Command request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);
       
        return result.IsValid ? new NoContentResult(): new BadRequestObjectResult(result.Errors);
    }
}
