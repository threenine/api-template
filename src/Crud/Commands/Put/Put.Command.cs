using Namespace.Resource.Put;
using MediatR;
using Threenine;
using Threenine.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace Namespace.Activities.Resource.Commands.Put;

public class Command : IRequest<SingleResponse<Response>>
{
   [FromRoute(Name = "id")] public Guid Id { get; set; }
   [FromBody] public DomainObject DomainObject { get; set; }
}


