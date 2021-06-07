using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Activities.Sample.Get
{
    public class GetSampleRequest : IRequest<GetSampleResponse>
    {
        [FromRoute(Name = "id")] public string Id { get; set; }
    }
}