---
layout: default
title: "Database Project"
parent: "Databases"
has_children: true
nav_order: 1
permalink: /docs/databases/database-project
mermaid: true
---

# Database Project

An important concept and principle that needs to be adhered to when developing Microservices is that each microservice will be responsible for and manage it's own database. This is due to the *Loose Coupling* nature of microservice architecture. All interactions with the service happens via its API, which encapsulates its implementation details, enabling the implementation of the service to change without impacting its clients.

> The Microservice architecture pattern decomposes a system into a set independently deployable services, each with its own database
>
> [Microservices Patterns: With examples in Java](https://www.amazon.com/Microservices-Patterns-examples-Chris-Richardson/dp/1617294543?_encoding=UTF8&qid=1666701078&sr=8-1&linkCode=sl1&tag=threenine05-20&linkId=7fe6977c970c43e31abb399a97949997&language=en_US&ref_=as_li_ss_tl)

The requirement for services to be loosely coupled and to collaborate only via API's prohibits services from communicating via a database.

Keeping data private enables a developer to change their services database schema without having to spend time coordinating with developers working on other services.  Not sharing database tables also improves runtime isolation.



### Microsoft Entity Framework Core

The API Template Pack simplifies the process of creating a Database per service concept by guiding you down the path of using Microsoft Entity Framework Core help in creating and managing your database. 

The best metric for measuring the correct size that a microservice should be, is that a well designed microservice should be a service capable of being developed by a small team with minimal lead time and with minimal collaboration with other teams.   

The microservice architecture structures an application as set of small loosely coupled services. Which improves Maintainability, Testability and Deployability to enable organisations to develop software faster.

The key to achieving this is that a services database should only be as big or as small as it needs to be, to deliver on the context that it needs too.  With this in mind, there is never a need to build any overly complex or elaborate database structures or schemas and to to always keep in mind that the core objective of the database within a service should be speed of transaction and performance.

With the objectives in mind, we have found that Microsoft Entity Framework Core is a more than suitable tool to use.  We have also tried to focus on ensuring that we make working with EF Core as easy and simple as possible. The result is that the API Solution Template automatically generates the typical Database project and configuration for you, enable you to focus on the important stuff.  That is, developing your Database.






