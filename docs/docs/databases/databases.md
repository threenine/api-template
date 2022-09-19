---
layout: default
title: "Databases"
nav_order: 3
has_children: true
permalink: /docs/databases
---

# Working with Databases

REST API standard has emerged as the most versatile and useful web service API. The simplicity, flexibility, and compatibility make it ideal for working with various types of data and interfacing with the most well-known applications available. Thiw results in a common requirement for REST based API's and Microservices is to be able to store, manipulate and provide data.  

The acronym API stands for _Application Programming Interface_, which is essentially a set of functions that facilitate the communication between two or more software applications, taking a request from one software application to another, then returns to the initiating software with a relevant response.  

The Requests & Responses will consist of data, which may require persisting, manipulation, transformation or often a blend of all. 


## Microservices and databases

In the world of Microservices it is often preferred that each service is responsible for its own database.  In his book, [Building Microservices - Designing fine grained systems](https://amzn.to/3UjNThu) discussed many of the points to be mindful of when developing microservices with databases and emphasises the importance of all microservices should have its own database as far as possible.

With all these aspects in mind the API Template Pack aims to make creating and managing databases within your API or microservice project as simple as possible. In fact, we take an opinionated view on which database system us the best to use, we have settled on PostgreSQL and have detailed our reasons [Why use PostgreSQL for your database](../docs/knowledge/postgres). 

### Bounded Context

When designing API's we tend to conceptualise them as Microservices and particularly concentrate and focus on the _Bounded Context_ that the API relates too.   

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

The API Template Pack, has been designed with implementing the [Database per service Context pattern](https://microservices.io/patterns/data/database-per-service.html) in mind


### Microsoft Entity Framework 

Entity Framework (EF) Core is a lightweight, extensible, and cross-platform version of the popular Entity Framework data access technology. [EF Core](https://docs.microsoft.com/en-us/ef/) is an object-relational mapper (ORM) that enables .NET developers to work with a database using .NET objects.

When using EF Core data access is performed by using a model. A model is made up of (domain model) entity classes and a derived context (DbContext) that represents a session with the database, allowing you to query and save data.

EF Core enables the generation of a model from an existing database, manually code a model to match your database, or use EF migrations technique to create a database from your model, using the code-first approach.

The [API Solution Template](../start/api-solution.md "API Solution Template") of the API Template Pack 


### Additional Resources

* [Book Review: Domain Driven Design - Tackling complexity in the heart of software](https://garywoodfine.com/book-review-domain-driven-design/ "Book Review: Domain Driven Design - Tackling complexity in the heart of software - Gary Woodfine")
* [Book Review: Implementing Domain Driven Design](https://garywoodfine.com/book-review-implementing-domain-driven-design/ "Book Review: Implementing Domain Driven Design - Gary Woodfine")
* [Book Review : Building Microservices](https://garywoodfine.com/book-review-building-microservices/
  "Book Review : Building Microservices - Gary Woodfine")