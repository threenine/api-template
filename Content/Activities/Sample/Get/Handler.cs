using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Threenine.ApiResponse;

namespace ApiProject.Activities.Sample.Get
{
    public class Handler : IRequestHandler<Query,SingleResponse<SampleDetail>>
    {
        public async Task<SingleResponse<SampleDetail>> Handle(Query request, CancellationToken cancellationToken)
        {
            /// Your Logic Goes here 
            // This is only to supply an example and you should do whatever you need to achieve here
            return await Task.FromResult(new SingleResponse<SampleDetail>( new SampleDetail
            {
                Id = Guid.NewGuid().ToString(),
                Name = nameof(SampleDetail)
            }));
        }
    }
}