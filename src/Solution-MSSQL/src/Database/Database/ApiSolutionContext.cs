using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Threenine.Configurations.PostgreSql;
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
       modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}