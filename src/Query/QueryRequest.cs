using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Threenine.ApiResponse;

namespace Namespace.QueryRequest;

[Route("QueryRequest")]
public class QueryRequest : EndpointBaseAsync.WithRequest<Command>.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public Post(IMediator mediator)
    {
        _mediator = mediator;
    }
        
        
    [HttpPost]
    [SwaggerOperation(
        Summary = "QueryRequest",
        Description = "QueryRequest",
        OperationId = "operationid",
        Tags = new[] { "QueryRequest" })
    ]
    [ProducesResponseType(StatusCodes.Status202Accepted, Type = typeof(Response))]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromBody] Command request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);
        return result.IsValid ? new AcceptedResult(new Uri(Routes.Submit, UriKind.Relative), new {result.Item.Title,  result.Item.Url }): new BadRequestObjectResult(result.Errors);
    }
}
