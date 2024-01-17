
using Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.ApiSolutions;

/// <summary>
/// This class is responsible for creating an instance of the ApiSolutionContext class, which is used as the
/// DbContext for accessing the underlying database.
/// This class is primarily used by the migrations and for the most part one should never really need to edit this class
/// and it is marked as internal so therefore should never be used outside of the Database project.
/// </summary>
internal class ApiSolutionContextFactory : IDesignTimeDbContextFactory<ApiSolutionContext>
{
    public ApiSolutionContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ApiSolutionContext> dbContextOptionsBuilder =
            new();

        dbContextOptionsBuilder.UseSqlServer(ConnectionStringNames.LocalBuild);
        return new ApiSolutionContext(dbContextOptionsBuilder.Options);
    }
}
