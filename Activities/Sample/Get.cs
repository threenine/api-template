using System.Threading;
using System.Threading.Tasks;
using ApiProject.Requests.Sample;
using ApiProject.Responses.Sample;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;


namespace ApiProject.Activities.Sample
{
   [Route("sample")]
    public class Get : BaseAsyncEndpoint.WithRequest<SampleRequest>.WithResponse<SampleResponse>
    {
        private readonly IMediator _mediator;

        public Get(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieve an article by id ",
            Description = "Retrieves a full articles ",
            OperationId = "EF0A3653-153F-4E73-8D20-621C9F9FFDC9",
            Tags = new[] {"Sample"})
        ]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SampleResponse))]
        [Produces("application/json")]
        public override async Task<ActionResult<SampleResponse>> HandleAsync([FromRoute] SampleRequest request, CancellationToken cancellationToken = new CancellationToken())
        {
            return await _mediator.Send(request, cancellationToken);
        }
    }
}