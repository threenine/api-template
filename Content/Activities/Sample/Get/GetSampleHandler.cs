using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ApiProject.Activities.Sample.Get
{
    public class GetSampleHandler : IRequestHandler<GetSampleRequest, GetSampleResponse>
    {
        public async Task<GetSampleResponse> Handle(GetSampleRequest getSampleRequest, CancellationToken cancellationToken)
        {
            /// Your Logic Goes here 
            // This is only to supply an example and you should do whatever you need to achieve here
            return await Task.FromResult(new GetSampleResponse
            {
                Id = Guid.NewGuid().ToString(),
                Name = nameof(GetSampleResponse)
            });
        }
    }
}