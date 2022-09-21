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

### Add Type Configurations

To create Entity Type Configuration by adding a new File to the `Database -> Configurations` 

###  BaseEntityTypeConfiguration<TEntity>

The API Template pack provides an easy to use `BaseEntityTypeConfiguration` abstract class which aims to simplify the creation of Entities that inherit from the `BaseEntity` class to enable the type configuration required on those classes so you don't have to concern yourselves with it.