---
layout: default
title: "Model Configuration Generation"
parent: "Getting Started"
nav_order: 4
---

# Model Configuration Generation

The API Template Pack provides a [BaseEntity](../../databases/entity-type-configuration/#what-is-baseentity) which is used when creating Database model. We also have preference of making use of Fluent Configuration API for the Entity Type Configuration.  

To simplify the process of creating your Model Configuration we provide the Model Configuration Template which can be run from the terminal, which create the stub class for you to complete.

By default the template will generate a new Model Configuration class to use MSSQL if
you want to use PosgreSQL you can make use of the `--usePOSGRE` switch to generate for
postgre

The template makes use of the following parameters

* `--model` Name of your Model class to generate the configuration for
* `--name` Name of your class to be created
* `--output` The preferred output location
* `--usePOSTGRE`  optional flag to create a new solution that uses a PostgreSQL database backend
* `--force`  Forces content to be generated even if it would change existing files. This is required when the template
  chosen would override existing files in the output directory.

```shell
 dotnet new modelconfig --model [Name of model] --output [your output location] --name [Name of you class]

```
to generate for Postgre use the `--usePOSTGRE` switch

```shell
 dotnet new modelconfig --model [Name of model] --output [your output location] --name [Name of you class]  --usePOSTGRE

```

In the following example we are going to generate a PostsConfiguration class for our Posts Model. Our preferred output location will be Configuraitons folder in our database project.  We will be executing the terminal command in the root of our project directory.

```shell
 dotnet new modelconfig --model Posts --output src/Database/Database/Configurations/ --name PostsConfiguration

```

The Output of this command will be the following class in the Database Configuration folder.

```csharp
public class PostsConfiguration : BaseEntityTypeConfiguration<Posts>
{
    public override void Configure(EntityTypeBuilder<Posts> builder)
    {
        builder.ToTable(nameof(Posts).ToLower());
        
        // Add configurations
        
        base.Configure(builder);
    }
}
```

> By default we will use the name of the model to lower case as the name of the table. You change this to suit your preferred name
> 

Once the class has been generated you can continue to add your configurations