---
layout: default
title: "Context Factory"
parent: "Database Project"
grand_parent: "Databases"
nav_path: /docs/databases/database-project/context-factory
nav_order: 2
---

# Database Context Factory

A factory for creating derived Context instances.  Implements the Microsoft Entity Framework Core `IDesignTimeDbContextFactory` to enable design-time services for context types that do not have a public default constructor. At design-time, derived `DbContext` instances can be created in order to enable specific design-time experiences such as Migrations. Design-time services will automatically discover implementations of this interface that are in the startup assembly or the same assembly as the derived context.

This class is also pre-generated for you and ready for you to start generating Migrations etc with

The Example below illustrates an example of a `ContextFactory` generated making use of PostgreSQL, which can be done making use of the `--postgre` switch
```csharp

internal class ArticlesContextFactory : IDesignTimeDbContextFactory<ArticlesContext>
{
    public ArticlesContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ArticlesContext> dbContextOptionsBuilder =
            new();

        dbContextOptionsBuilder.UseNpgsql(ConnectionStringNames.LocalBuild);
        return new ArticlesContext(dbContextOptionsBuilder.Options);
    }
}

```

### Additional Resources

* [IDesignTimeDbContextFactory Interface](https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.design.idesigntimedbcontextfactory-1?view=efcore-6.0)
* [IDbContextFactory Interface](https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.infrastructure.idbcontextfactory-1?view=entity-framework-6.2.0) 

