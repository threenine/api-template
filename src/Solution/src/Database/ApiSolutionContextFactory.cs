
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.ApiSolutions;

internal class ApiSolutionContextFactory : IDesignTimeDbContextFactory<ApiSolutionContext>
{
    public ApiSolutionContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<SolutionContext> dbContextOptionsBuilder =
            new();

        dbContextOptionsBuilder.UseSqlServer(@"localBuild");
        return new SolutionContext(dbContextOptionsBuilder.Options);
    }
}
