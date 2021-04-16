using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyProject.Responses.Sample;

namespace MyProject.Requests.Sample
{
    public class SampleRequest : IRequest<SampleResponse>
    {
        [FromRoute(Name = "id")] public string Id { get; set; }
    }
}