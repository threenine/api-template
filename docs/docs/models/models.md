---
layout: default
title: "Models"
nav_order: 4
has_children: true
permalink: /docs/models
---

# Models Project

The Models project is used to define the Entities used in the application, typically these are the Database Entities. A model is made up of (domain model)
entity classes and a derived context ([Database Context](../docs/databases/context)) that represents a session with the database, allowing
you to query and save data.

In DDD, there are artifacts to express, create, and retrieve domain models: Entity. An object that is not defined by its attributes, but rather by a thread of continuity and its identity.

In the API Template Pack an Entity, may typically be a business object that may be represented as a Database object i.e. Table, although it does not exclusively mean this.

### What is an Entity

An `ENTITY` is anything that has continuity through a life cycle and distinctions independent of attributes that are important to the application's user.

In *Domain-Driven Design* (DDD), an Entity is something that has an identifier and an owner. It can be mutable, but has a thread of continuity throughout its lifetime.

There are important characteristics of entities:

* An Entity has an identifier
* An Entity has an owner
* An Entity can be mutable
* An Entity has a thread of continuity