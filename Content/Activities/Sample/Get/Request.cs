using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Activities.Sample.Get
{
    public class Request : IRequest<Response>
    {
        [FromRoute(Name = "id")] public string Id { get; set; }
    }
}