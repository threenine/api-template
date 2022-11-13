using Namespace.Resource.Post;
using Threenine;
using MediatR;
using Threenine.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace Namespace.Activities.Resource.Commands.Post;

public class Command : IRequest<SingleResponse<Response>>
{
      [FromBody] public DomainObject DomainObject { get; set; }  
}



