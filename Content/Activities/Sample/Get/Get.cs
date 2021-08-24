using System.Threading;
using System.Threading.Tasks;
using ApiProject.Activities.Sample.Get;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiProject.Content.Activities.Sample
{
   [Route(RouteNames.Sample)]
    public class Get : BaseAsyncEndpoint.WithRequest<Query>.WithResponse<Response>
    {
        private readonly IMediator _mediator;

        public Get(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieve a sample response by id ",
            Description = "Retrieves a sample response ",
            OperationId = "EF0A3653-153F-4E73-8D20-621C9F9FFDC9",
            Tags = new[] {RouteNames.Sample})
        ]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesErrorResponseType(typeof(NotFoundResult))]
        [Produces("application/json")]
        public override async Task<ActionResult<Response>> HandleAsync([FromRoute] Query query, CancellationToken cancellationToken = new())
        {
            var result = await _mediator.Send(query, cancellationToken);
            if (result == null) return new NotFoundResult();
            return new OkObjectResult(result);
        }
    }
}