using MediatR;
using Microsoft.AspNetCore.Mvc;
using Threenine.ApiResponse;

namespace Namespace.Activities.Resource.Queries.GetAll;

public class Query : IRequest<SingleResponse<Response>>
{
   [FromRoute]  public Guid Id { get; set; }   
}


