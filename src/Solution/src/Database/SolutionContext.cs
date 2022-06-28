using System.Reflection;
using Kingsbridge.Database;
using Kingsbridge.Engagements;
using Microsoft.EntityFrameworkCore;


namespace Database.Solutions;

public class SolutionContext : BaseContext<SolutionContext>
{
    public SolutionContext(DbContextOptions<SolutionContext> options)
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