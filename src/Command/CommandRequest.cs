using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Threenine.ApiResponse;

namespace Namespace.CommandRequest;

[Route("CommandRequest")]
public class CommandRequest : EndpointBaseAsync.WithRequest<Command>.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public CommandRequest(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    [SwaggerOperation(
        Summary = "CommandRequest",
        Description = "CommandRequest",
        OperationId = "operationid",
        Tags = new[] { "CommandRequest" })
    ]
    [ProducesResponseType(StatusCodes.Status202Accepted, Type = typeof(Response))]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromBody] Command request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);
        //TODO: Set your prefered response result
        return result.IsValid ? new AcceptedResult(new Uri("CommandRequest", UriKind.Relative), new {result.Item.Title,  result.Item.Url }): new BadRequestObjectResult(result.Errors);
    }
}
