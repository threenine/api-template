namespace Namespace.Resource.Commands.Patch;

public class Command : IRequest<SingleResponse<Response>>
{
        [FromRoute(Name = "id")] public Guid  Id { get; set; }
        [FromBody]  public JsonPatchDocument<DTO> DTO{ get; set; }
}

