using FluentValidation;
namespace Namespace.Resource.Commands.Patch;

public class Validator : AbstractValidator<Command>
{
    public Validator()
    {
        RuleFor(x => x.Id).NotEmpty();     
    }       
}
