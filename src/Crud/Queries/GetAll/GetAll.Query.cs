namespace Namespace.Resource.Queries.GetAll;

public class Query : IRequest<SingleResponse<Response>>
{
   [FromRoute]  public Guid Id { get; set; }   
}


