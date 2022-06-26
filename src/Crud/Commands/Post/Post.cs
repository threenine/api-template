using System;
using System.Threading;
using System.Threading.Tasks;

namespace Namespace.Resource.Commands.Post;

[Route(Routes.Resource)]
public class Post : EndpointBaseAsync.WithRequest<Command>.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public Post(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    [SwaggerOperation(
        Summary = "Post",
        Description = "Post",
        OperationId = "1f557ca8-c452-48b4-84f1-5dc268e033c4",
        Tags = new[] { Routes.Resource })
    ]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync([FromBody] Command request, CancellationToken cancellationToken = new())
    {
        var result = await _mediator.Send(request, cancellationToken);
       
        return result.IsValid ? new CreatedResult(new Uri(Routes.ChargeRates, UriKind.Relative), new { result.Item }): new BadRequestObjectResult(result.Errors);
    }
}
