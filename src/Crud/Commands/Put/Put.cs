using Api.Activities;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Threenine.ApiResponse;

namespace  Namespace.Activities.Resource.Commands.Put;

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
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromRoute] Command request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);

        if (result.IsValid)
            return new NoContentResult();
        
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
