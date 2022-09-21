---
layout: default
title: "Databases"
nav_order: 3
has_children: true
permalink: /docs/databases
---

# Working with Databases

REST API standard has emerged as the most versatile and useful web service API. The simplicity, flexibility, and compatibility make it ideal for working with various types of data and interfacing with the most well-known applications available. This results in a common requirement for REST based API's and Microservices is to be able to store, manipulate and provide data.  

The acronym API stands for _Application Programming Interface_, which is essentially a set of functions that facilitate the communication between two or more software applications, taking a request from one software application to another, then returns to the initiating software with a relevant response.  

The Requests & Responses will consist of data, which may require persisting, manipulation, transformation or often a blend of all. 


## Microservices and databases

In the world of Microservices it is often preferred that each service is responsible for its own database.  In his book, [Building Microservices - Designing fine grained systems](https://amzn.to/3UjNThu) Sam Newman discussed many of the points to be mindful of when developing microservices with databases and emphasises the importance of all microservices should have its own database as far as possible.

With all these aspects in mind the API Template Pack aims to make creating and managing databases within your API or microservice project as simple as possible. In fact, we take an opinionated view on which database system is the best to use, we have settled on PostgreSQL and have detailed our reasons [Why use PostgreSQL for your database](../docs/knowledge/postgres).  

### Bounded Context

When designing API's we tend to conceptualise them as Microservices because we particularly concentrate on the _Bounded Context_ that the API relates too.   

The *Bounded Context* (BC) is a term derived from *Domain Driven Design* (DDD), a concept popularised by Eric Evans in his book [Domain Driven Design - Tackling complexity in the hart of software](https://amzn.to/3QSbzXA) and discussed further by Vaughn Vernon in [Implementing Domain Driven Design](https://amzn.to/3eRelyR)

> **Bounded context is explicit and liguistic**
> 
> A bounded context is an explicit boundary within which a domain model exists. Inside the boundary all terms and phrases of the _Ubiquitos Language_ have specific meaning, and the model reflects the language with exactness.
> 
> [Implementing Domain Driven Design](https://amzn.to/3eRelyR)

The concept of _microservice_  deals with large models by dividing them into multiple BCs and being explicit about their
boundaries. Each BC must have its own model and database; likewise, each microservice owns its
related data. In addition, each BC usually has its own ubiquitous language to help communication
between software developers and domain experts.

The API Template Pack, has been designed with implementing the [Database per service Context pattern](https://microservices.io/patterns/data/database-per-service.html) in mind.   This pattern helps to enforce the following attributes of Microservices:
* Loose Coupling - Services can be developed, deployed and scaled independently
* Replication and Sharding - Databases must sometimes be replicated and sharded in order to scale
* Mixed Data storage - Different services can make use of different data storage and technologies.

This results in the service’s database is effectively part of the implementation of that service. It cannot be accessed directly by other services.

> Microservices take the concept of a domain partitioned architecture to the extreme. Each service is meant to represent a domain or subdomain; in many ways, microservices is the physical embodiment of the logical concepts in Domain-Driven Design
> 
> [Fundamentals of Software Architecture](https://amzn.to/3DFnODL)

#### Small Context Boundaries

There are two very important aspects you need to consider when defining your _Bounded Context_ 
1. Create boundaries around things that need cohesion
2. Avoid chatty communications between microservices

> Cohesion is key within a single bounded context

When developing Microservices we should strive to make each service autonomous, therefore if a service must rely on another service to directly service a request, it is not truly autonomous.

### Identify domain-model boundaries

The goal when identifying model boundaries and size for each microservice isn’t to get to the most
granular separation possible, although you should tend toward the most concise and precise microservices as possible.  Your ultimate goals goal should be to get to the most meaningful separation guided by your domain
knowledge. The emphasis isn’t on the size, but instead on business capabilities.

If there is clear cohesion  for a certain area of the application based on a high number of dependencies, that indicates the need for a single microservice.

Cohesion is a way to identify how to break apart or group together microservices. Ultimately, while you gain more knowledge about the domain, you should iteratively adapt the size of your microservice.

### Microsoft Entity Framework 

Entity Framework (EF) Core is a lightweight, extensible, and cross-platform version of the popular Entity Framework data access technology. [EF Core](https://docs.microsoft.com/en-us/ef/) is an object-relational mapper (ORM) that enables .NET developers to work with a database using .NET objects.

When using EF Core data access is performed by using a model. A model is made up of (domain model) entity classes and a derived context (DbContext) that represents a session with the database, allowing you to query and save data.

EF Core enables the generation of a model from an existing database, manually code a model to match your database, or use EF migrations technique to create a database from your model, using the code-first approach.

The [API Solution Template](../start/api-solution.md "API Solution Template") of the API Template Pack generates the 3 projects which assists in defining:

* Database project
* Models project
* DTOs project


### Additional Resources

* [Book Review: Domain Driven Design - Tackling complexity in the heart of software](https://garywoodfine.com/book-review-domain-driven-design/ "Book Review: Domain Driven Design - Tackling complexity in the heart of software - Gary Woodfine")
* [Book Review: Implementing Domain Driven Design](https://garywoodfine.com/book-review-implementing-domain-driven-design/ "Book Review: Implementing Domain Driven Design - Gary Woodfine")
* [Book Review : Building Microservices](https://garywoodfine.com/book-review-building-microservices/
  "Book Review : Building Microservices - Gary Woodfine")
* [Book Review: Fundamentals of Software Architecture - An Engineering Approach](https://garywoodfine.com/book-review-fundamentals-of-software-architecture/ "Book Review: Fundamentals of Software Architecture - Gary Woodfine")
* [Microservices - a definition of this new architectural term](https://martinfowler.com/articles/microservices.html "Microservices - a definition of this new architectural term - Martin Fowler")