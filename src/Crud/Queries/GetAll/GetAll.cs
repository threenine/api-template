using System.Threading;
using System.Threading.Tasks;

namespace Namespace.Resource.Queries.GetAll;

[Route(Routes.Resource)]
public class GetAll : EndpointBaseAsync.WithoutRequest.WithActionResult<SingleResponse<Response>>
{
    private readonly IMediator _mediator;

    public GetAll(IMediator mediator)
    {
        _mediator = mediator;
    }
        
    [HttpGet]
    [SwaggerOperation(
        Summary = "GetAll",
        Description = "GetAll",
        OperationId = "9ccfda2c-789f-480c-a431-553b639dc441",
        Tags = new[] { Routes.Resource })
    ]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
    [ProducesErrorResponseType(typeof(BadRequestObjectResult))]
    public override async Task<ActionResult<SingleResponse<Response>>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await _mediator.Send(new Query(), cancellationToken);

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
