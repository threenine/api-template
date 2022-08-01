---
layout: default
title: "Resource-Based API"
parent: Introduction
nav_order: 2
---
# Resource-Based API Design

A resource is a digital representation of a concept, often an entity or collection of entities that may change over time. It consists of unique name or identifier that can reference documents, images, collections of other resources or a digital representation of anything in the real world such as a person or thing.  Resources may even represent business processes and workflows.

Resource-based API's focus on the interactions across a network, independent of how they are stored in a database or manifested as objects. The provide different operations or affordances as possible interactions with a specific resource.  Resources support multiple representations that allow Web Apps, Mobile Apps and reporting tools to interact with the resource using different media formats such as JSON or XML.

> The key abstraction of information in REST is a resource. Any information that can be named can be a resource: a document or image, a temporal service (e.g. "today's weather in Los Angeles"), a collection of other resources, a non-virtual object (e.g. a person), and so on. In other words, any concept that might be the target of an author's hypertext reference must fit within the definition of a resource. A resource is a conceptual mapping to a set of entities, not the entity that corresponds to the mapping at any particular point in time. - [Roy Fielding](https://www.ics.uci.edu/~fielding/pubs/dissertation/rest_arch_style.htm#sec_5_2_1_1)
> 
>

Resources form the nucleus of any REST API design. Resource identifiers (URI), Resource representations, API operations etc. are all built around the concept of *Resources*. It is very important to select the right resources and model the resources at the right granularity while designing the REST API so that the API consumers get the desired functionality from the APIs, the APIs behave correctly and the APIs are maintainable.


### Resources are not Data Models.

It is vitally important to recognize that *resources are not the same thing as a data model*

A data model, often reflected as a schema design in a database, is optimised for the read and write operations necessary to support the required Input/Output (I/O) operations necessary to support the required I/O performance and reporting needs of a solution.

Data operations may in fact be part of an API, the data model should not be use as the basis of the API Design.  Data models meet a specific set of requirements, including the read and write performance, data storage optimisations, query support, which mean that data models are optimised for the internal details of an application.

Web API designed directly to a data or object model expose the internal implementation details to the API consumers. This often results in fragile API's that introduce significant design changes when the underlying data model changes.

Web API's generally seek to address entirely different sets of goals including:

- Delivering outcomes and experiences
- Optimised network access
- Programming and Database independence

API's are generally used as an integration layer between systems therefore they should remain stable over long periods of time, whereas data models may change to accomodate new or changing data access requirements.

*API's may have an impact on a Data Model, they should evovle completely separately*.

# Resources are not object or Domain Models

Objects support collaboration with a codebase, and are often used to map to data models into code for easier manipulation.  Domain models are typically comprised of object used to represent the sepcific business domain, and used in a variety of ways to address the needs of the system often traversing different transactional contexts based on how they are applied.

Object and Domain models can suffer from the same issues as exposed data models:
- Constant Code Changes
- Network chattiness
- Data inconsistencies

Web API's are most effective when they take the transactional boundaries into consideration rather than directly exposing the internal domain of object model behaviour.

Great API's designs avoid leaking internal details, including database design choices or object mapping by shifting data design to message design.

# Resource-based API's exchange messages.

Resource-based API's are used to facilitate conversations between the business and users or remote systems.

API design considers the conversational message exchange between system to produce desired outcomes by customers, partners and workforces. A great API design considers how these conversations evolve as requirements change.
