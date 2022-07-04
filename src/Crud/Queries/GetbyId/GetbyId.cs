using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Threenine.ApiResponse;
using Api.Activities;

namespace Namespace.Resource.Queries.GetbyId;

[Route(Routes.Resource)]
public class GetbyId : EndpointBaseAsync.WithRequest<Query>.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public GetbyId(IMediator mediator)
    {
        _mediator = mediator;
    }
        
    [HttpGet("{id:guid}")]
    [SwaggerOperation(
        Summary = "GetbyId",
        Description = "GetbyId",
        OperationId = "d0c17632-4b2e-4bcd-b074-bd126ddcf5e2",
        Tags = new[] { Routes.Resource })
    ]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
    [ProducesErrorResponseType(typeof(BadRequestObjectResult))]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromRoute] Query request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);
       
        if(result.IsValid) 
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
