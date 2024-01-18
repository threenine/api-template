using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Database.ApiSolutions
{
    public static class Initializer
    {
        public static void DatabaseInitialise(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetService<ApiSolutionContext>();
            context.Database.Migrate();
        }
    }
}