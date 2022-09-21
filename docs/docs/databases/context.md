---
layout: default
title: "Database Context"
parent: "Database Project"
grand_parent: "Databases"
nav_path: /docs/databases/database-project/context
nav_order: 1
---

# Database Context

A Database Context instance represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database and group together changes that will then be written back to the store as a unit. 

This class usually used with a derived type that contains `DbSet<TEntity>` properties for the root entities of the model. These sets are automatically initialized when the instance of the derived class is created.

Once you have defined your [Entity Type Configurations](entity-type-configuration.md) then you will want to expose the `DbSet<TEntity>` to enable them to accessed.

### Additional references

* [DbContext Class](https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?view=entity-framework-6.2.0)