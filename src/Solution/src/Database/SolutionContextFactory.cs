
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.Solutions;

internal class SolutionContextFactory : IDesignTimeDbContextFactory<SolutionContext>
{
    public SolutionContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<SolutionContext> dbContextOptionsBuilder =
            new();

        dbContextOptionsBuilder.UseSqlServer(@"localBuild");
        return new SolutionContext(dbContextOptionsBuilder.Options);
    }
}
