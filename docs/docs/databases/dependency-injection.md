---
layout: default
title: "Dependency Injection"
parent: "Database Project"
grand_parent: "Databases"
nav_path: /docs/databases/database-project/context
nav_order: 4
---

# Database project dependency Injection

To add a database project to any project just requires two calls, to be executed in the `Program.cs` of your target 
project.  

### To add the database
To add the database to the project simply call the `AddDatabase` extension method, and passing in access to the current
projects configuration 

```csharp
builder.Services.AddDatabase(builder.Configuration);
```

Then after your Builder has been initialised you simply then call the `DatabaseInitialise` method

```csharp
app.DatabaseInitialise();
```