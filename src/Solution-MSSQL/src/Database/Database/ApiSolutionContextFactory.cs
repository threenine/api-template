﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.ApiSolutions;

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