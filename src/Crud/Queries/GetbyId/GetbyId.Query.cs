namespace Namespace.Resource.Queries.GetbyId;

public class Query : IRequest<SingleResponse<Response>>
{
    [FromRoute(Name = "id")] public Guid Id { get; set; }  
}


