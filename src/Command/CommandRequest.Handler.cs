using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Threenine.ApiResponse;


namespace Namespace;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
   public Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
       
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
       return new SingleResponse<Response>(new Response())
    }
}
