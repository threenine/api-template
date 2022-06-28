using System.Reflection;
using Kingsbridge.Database;
using Kingsbridge.Engagements;
using Microsoft.EntityFrameworkCore;


namespace Database.Solutions;

public class ApiSolutionContext : BaseContext<ApiSolutionContext>
{
    public ApiSolutionContext(DbContextOptions<ApiSolutionContext> options)
        : base(options)
    {
    }

    //TODO: ADD your DbSets here

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Solution");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}