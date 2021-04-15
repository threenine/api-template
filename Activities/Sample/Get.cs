using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using webtemplate.Requests;
using webtemplate.Responses;

namespace ApiEndpoint.Activities.Sample
{
    public class Get : BaseAsyncEndpoint.WithRequest<SampleRequest>.WithResponse<SampleResponse>
    {
        [HttpGet("{category}/{id}")]
        [SwaggerOperation(
            Summary = "Retrieve an article by id ",
            Description = "Retrieves a full articles ",
            OperationId = "EF0A3653-153F-4E73-8D20-621C9F9FFDC9",
            Tags = new[] {"Article"})
        ]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SampleResponse))]
        [Produces("application/json")]
        public override Task<ActionResult<SampleResponse>> HandleAsync(SampleRequest request, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new System.NotImplementedException();
        }
    }
}