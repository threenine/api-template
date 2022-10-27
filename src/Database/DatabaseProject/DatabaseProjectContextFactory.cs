
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DatabaseProject;

internal class DatabaseProjectContextFactory : IDesignTimeDbContextFactory<DatabaseProjectContext>
{
    public DatabaseProjectContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<DatabaseProjectContext> dbContextOptionsBuilder =
            new();

        dbContextOptionsBuilder.UseNpgsql(ConnectionStringNames.LocalBuild);
        return new DatabaseProjectContext(dbContextOptionsBuilder.Options);
    }
}
