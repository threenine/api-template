using System;
using System.Threading;
using System.Threading.Tasks;
using ApiProject.Content.Requests.Sample;
using ApiProject.Content.Responses.Sample;
using MediatR;

namespace ApiProject.Content.Handlers.Sample
{
    public class GetSampleHandler : IRequestHandler<SampleRequest, SampleResponse>
    {
        public async Task<SampleResponse> Handle(SampleRequest request, CancellationToken cancellationToken)
        {
            /// Your Logic Goes here 
            // This is only to supply an example and you should do whatever you need to achieve here
            return await Task.FromResult(new SampleResponse
            {
                Id = Guid.NewGuid().ToString(),
                Name = nameof(SampleResponse)
            });
        }
    }
}