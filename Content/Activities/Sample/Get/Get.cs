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
   [Route("sample")]
    public class Get : BaseAsyncEndpoint.WithRequest<Request>.WithResponse<Response>
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
            Tags = new[] {"Sample"})
        ]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [Produces("application/json")]
        public override async Task<ActionResult<Response>> HandleAsync([FromRoute] Request request, CancellationToken cancellationToken = new CancellationToken())
        {
            return await _mediator.Send(request, cancellationToken);
        }
    }
}