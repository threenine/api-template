using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Threenine.ApiResponse;

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
          
        if (result.IsValid)
            return new CreatedResult(new Uri(Routes.Resource, UriKind.Relative), new { result.Item.Id });

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
