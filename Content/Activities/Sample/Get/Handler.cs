using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ApiProject.Activities.Sample.Get
{
    public class Handler : IRequestHandler<Query, Response>
    {
        public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
        {
            /// Your Logic Goes here 
            // This is only to supply an example and you should do whatever you need to achieve here
            return await Task.FromResult(new Response
            {
                Id = Guid.NewGuid().ToString(),
                Name = nameof(Response)
            });
        }
    }
}