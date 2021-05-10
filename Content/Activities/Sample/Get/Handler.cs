using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ApiProject.Activities.Sample.Get
{
    public class Handler : IRequestHandler<Request, Response>
    {
        public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
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