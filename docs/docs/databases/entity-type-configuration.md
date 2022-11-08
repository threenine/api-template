---
layout: default
title: "Entity Type Configuration"
parent: "Database Project"
grand_parent: "Databases"
nav_path: /docs/databases/database-project/entity-type-configuration
nav_order: 3
---

# Entity Type Configuration

The API Template Pack guides developers down the path of implementing Fluent API to configure models. The reason being that this is the  most powerful method of configuration and allows configuration to be specified without modifying your entity classes. Fluent API configuration has the highest precedence and will override conventions and data annotations.

### What is BaseEntity

The BaseEntity is an abstract class that can be used to create a base entity object for all Models that provides all the typical base properties often required for a database entity

* ID - a uuid property
* Active - useful for soft deletes of rows
* Created - a datetime timestamp for a date and time an row was initially created
* Modified - a datetime timestamp for a date and time an row was initially created

### Add Type Configurations

To create Entity Type Configuration by adding a new File to the `Database -> Configurations` 

The API Template Pack provides the [Model Configuration Template](../../start/model-configuration)

###  BaseEntityTypeConfiguration<TEntity>

The API Template pack provides an easy to use `BaseEntityTypeConfiguration` abstract class which aims to simplify the creation of Entities that inherit from the `BaseEntity` class to enable the type configuration required on those classes so you don't have to concern yourselves with it.

To make use of the `BaseEntityTypeConfiguration` is simply create a configuration class and inherit from the class the BaseEntityTypeConfiguration class.  

In the example below we'll be creating  Posts confgiuration file for a `Posts` model. We can then use the override Configure to define our configuration, only concentrating on the core properties we want to define.

The `BaseEntityTypeConfiguration` will ensure our ID, Created, Modified and Active properties are automatically defined for us when we generate migrations.


```csharp
public class PostsConfiguration : BaseEntityTypeConfiguration<Posts>
{
   public override void Configure(EntityTypeBuilder<Posts> builder)
   {
      builder.ToTable(nameof(Posts).ToLower());

      builder.Property(x => x.Title)
         .HasColumnType(ColumnTypes.Varchar)
         .HasMaxLength(255)
         .IsRequired();
      
      builder.Property(x => x.Summary)
         .HasColumnType(ColumnTypes.Varchar)
         .HasMaxLength(300)
         .IsRequired();
      
      builder.Property(x => x.Permalink)
         .HasColumnType(ColumnTypes.Varchar)
         .HasMaxLength(255)
         .IsRequired();
      
      builder.Property(x => x.Published)
         .HasColumnType(ColumnTypes.Timestamp)
         .IsRequired();
    
      builder.HasOne(x => x.Source)
         .WithMany(x => x.Posts)
         .HasForeignKey(x => x.SourceId);
      
      base.Configure(builder);
   }
}
```


### Additional resources

* [Use fluent API to configure a model](https://learn.microsoft.com/en-us/ef/core/modeling/#use-fluent-api-to-configure-a-model)
