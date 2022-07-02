namespace  Namespace.Resource.Commands.Put;

public class Command : IRequest<SingleResponse<Response>>
{
   [FromRoute(Name = "id")] public Guid Id { get; set; }
   [FromBody] public DTO DTO { get; set; }
}


