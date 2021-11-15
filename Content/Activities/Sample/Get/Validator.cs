using FluentValidation;

namespace ApiProject.Activities.Sample.Get
{
    public class Validator : AbstractValidator<Query>
    {
        public Validator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
        }
    }
}