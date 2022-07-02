using Dtos;
using MediatR;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Threenine.ApiResponse;

namespace Namespace.Resource.Commands.Patch;

public class Command : IRequest<SingleResponse<Response>>
{
        [FromRoute(Name = "id")] public Guid  Id { get; set; }
        [FromBody]  public JsonPatchDocument<DTO> DTO{ get; set; }
}

