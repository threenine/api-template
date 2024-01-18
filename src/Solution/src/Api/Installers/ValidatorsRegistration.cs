using Database.ApiSolutions;
using FluentValidation;

public static class ValidatorsRegistration
{
    public static IServiceCollection RegisterValidators(this IServiceCollection services, Type type)
    {
        services.AddValidatorsFromAssemblies(new[] { typeof(Program).Assembly , typeof(ApiSolutionContext).Assembly});
        services.AddValidatorsFromAssembly(type.Assembly);
        return services;
    }
}