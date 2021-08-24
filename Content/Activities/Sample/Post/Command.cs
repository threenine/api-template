using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Content.Activities.Sample.Post
{
    public class Command : IRequest<Unit>
    {
        [FromRoute(Name = "id")] public string Id { get; set; }
    }
}