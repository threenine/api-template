using System.Reflection;
using Microsoft.EntityFrameworkCore;

using Threenine;

namespace Database.ApiSolutions;

public class ApiSolutionContext : BaseContext<ApiSolutionContext>
{
    public ApiSolutionContext(DbContextOptions<ApiSolutionContext> options)
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