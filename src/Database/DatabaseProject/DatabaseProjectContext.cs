using System.Reflection;
using Microsoft.EntityFrameworkCore;
#if(useMSSQL)
using Threenine.Configurations.SqlServer;
#endif
#if (usePOSTGRE)
using Threenine.Configurations.PostgreSql;
#endif
using Threenine;
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
#if (usePOSTGRE)
        modelBuilder.HasPostgresExtension(PostgreExtensions.UUIDGenerator);
#endif
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}