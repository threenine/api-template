---
layout: default
title: "Introduction to CQRS"
parent: Introduction
nav_order: 6
---

The API Template Pack leads down to an opinionated path to implementing a [CQRS pattern](https://garywoodfine.com/what-is-cqrs/ "What is CQRS | Gary Woodfine"), the real benefits of introducing this pattern will come to fruition in later versions of the API Template Pack when we start delving more into the Microservices, Event-Storming and the Event-Driven Architecture aspects of the API Template Pack. However, at this early stage it is still quite important to understand the fundamental basics of CQRS and the how and why the API Template Pack starts you on the path from the very beginning.

### Splitting Models into Read & Write Operations

At its most fundamental basic level the CQRS pattern primary focus is primarily focused on ensuring the splitting up your read and write models.  The primary concept is that the way you read data probably will in all likelihood look entirely different to the way that it is written. And trying to use the same models for both can lead to a lot of bloat that can be confusing. 

For the most part CQRS does not necessarily have any opinionated solution in regards to the databases etc. , although many may think the pattern itself implies you need different Write AND Read datastores.  This is most definitely not the case.  However, depending on the complexity and requirements of your project CQRS can be and is used to fulfil this kind of architecture, but it is by no means a hard requirement.

#### Commands & Queries

In CQRS Write & Read operations are defined as  Commands & Queries

##### Commands

A Command is an operation that can mutate the data without returning a value. Which are essentially any write operations, such as **Create**, **Update** and **Delete** operations.

##### Queries

Queries are operations that will never mutate data and will always return values and mostly comprise of **Read** operations.


The API Template Pack steers you down the path of helping you to generate Commands & Queries folders for your endpoints and will also assist in helping you to generate individual folders for each command and query objects.  This ensures the implementation of the **Single Responsibility Principle** , which is also a leading concept within the implementation of the logic itself.  Each class within the Endpoint has a Single Responsibility, and only provides the functionality required to fulfil its purpose.  All classes combined combined together fulfil the purpose of the endpoint, but individually they only fulfil their specific purpose. These purposes are:

- Endpoint
- Validation
- Mapping
- Handler 
- Request 
- Response





