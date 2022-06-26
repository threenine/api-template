namespace  Namespace.Resource.Commands.Put;

public class Validator : AbstractValidator<Command>
{
    public Validator()
    {
        RuleFor(x => x.Id).NotEmpty();
        
        // TODO: Add Validation for Object
    }       
}
