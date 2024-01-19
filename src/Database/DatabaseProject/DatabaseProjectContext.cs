using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProject;

public class DatabaseProjectContext : BaseContext<DatabaseProjectContext>
{
    public DatabaseProjectContext(DbContextOptions<DatabaseProjectContext> options)
        : base(options)
    {
    }
  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(DefaultSchema.Name);
#if (postgre)
        modelBuilder.HasPostgresExtension(PostgreExtensions.UUIDGenerator);
#endif
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}