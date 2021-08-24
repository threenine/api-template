using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiProject.Content.Activities.Sample.Post
{
    [Route(RouteNames.Sample)]
    public class Post : BaseAsyncEndpoint.WithRequest<Command>.WithoutResponse
    {
        private readonly IMediator _mediator;

        public Post(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Retrieve a sample response by id ",
            Description = "Retrieves a sample response ",
            OperationId = "82FE20DE-D12A-40A0-A297-3BEB626F97C0",
            Tags = new[] {RouteNames.Sample})
        ]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesErrorResponseType(typeof(UnprocessableEntityResult))]
        public override async Task<ActionResult> HandleAsync(Command request,
            CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                var result = await _mediator.Send(request, cancellationToken);
                return new CreatedResult(new Uri(RouteNames.Sample, UriKind.Relative), new {id = result});
            }
            catch (Exception e)
            {
                return new UnprocessableEntityResult();
            }
           
        }
    }
}