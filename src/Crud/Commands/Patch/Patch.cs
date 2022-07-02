using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Threenine.ApiResponse;
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
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromRoute] Command request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);

        if (result.IsValid)
            return new OkObjectResult(result.Item);
             
        return await HandleErrors(result.Errors);
    }
    private Task<ActionResult> HandleErrors(List<KeyValuePair<string, string[]>> errors)
    {
        ActionResult result = null;
        errors.ForEach(error =>
        {
            result = error.Key switch
            {
                ErrorKeyNames.Conflict => new ConflictResult(),
                _ => new BadRequestObjectResult(errors)
            };
        });
        return Task.FromResult(result);
    }
}
