using ApiProject.Content.Responses.Sample;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Content.Requests.Sample
{
    public class SampleRequest : IRequest<SampleResponse>
    {
        [FromRoute(Name = "id")] public string Id { get; set; }
    }
}