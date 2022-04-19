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
public class QueryRequest : EndpointBaseAsync.WithRequest<Query>.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public QueryRequest(IMediator mediator)
    {
        _mediator = mediator;
    }
        
    [HttpGet]
    [SwaggerOperation(
        Summary = "QueryRequest",
        Description = "QueryRequest",
        OperationId = "operationid",
        Tags = new[] { "QueryRequest" })
    ]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
    [ProducesErrorResponseType(typeof(BadRequestObjectResult))]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromRoute] Query request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);
        //Todo: Set your prefered result
        return result.IsValid ? new OkObjectResult(result.Item) : new BadRequestObjectResult(result.Errors);
    }
}snake
