using FluentValidation;

namespace ApiProject.Activities.Sample.Get
{
    public class Validator : AbstractValidator<Query>
    {
        public Validator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}