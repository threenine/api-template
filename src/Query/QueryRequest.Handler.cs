using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Threenine.ApiResponse;


namespace Namespace.QueryRequest;

public class Handler : IRequestHandler<Query, SingleResponse<Response>>
{
    public Handler()
    {
       
    }

    public async Task<SingleResponse<Response>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new SingleResponse<Response>(new Response());
    }
}
