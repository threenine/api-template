using Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Threenine;
using Threenine.Data.DependencyInjection;
using Threenine.Services;

namespace Database.ApiSolutions;

public static class DependencyInjection
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(ConnectionStringNames.Default);
        ArgumentException.ThrowIfNullOrEmpty(connectionString);
  
        services.AddDbContext<ApiSolutionContext>(
#if (postgre)
            x => x.UseNpgsql(connectionString,   
                b => b.MigrationsAssembly(typeof(ApiSolutionContext).Assembly.FullName)),
            ServiceLifetime.Transient
#endif 

#if (mssql)
         x => x.UseSqlServer(connectionString,
            b => b.MigrationsAssembly(typeof(ApiSolutionContext).Assembly.FullName)),
        ServiceLifetime.Transient
#endif
                )
            .AddUnitOfWork<ApiSolutionContext>();
        services.AddTransient(typeof(IDataService<>), typeof(DataService<>));
        
        return services;

    }
}