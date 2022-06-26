namespace Namespace.Resource.Queries.GetbyId;

public class Validator : AbstractValidator<Query>
{
    public Validator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }       
}
