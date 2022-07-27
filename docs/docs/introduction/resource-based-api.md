---
layout: default
title: "Resource-Based API"
parent: Introduction
nav_order: 2
---
# Resource-Based API Design

A resource is a digital representation of a concept, often an entity or collection of entities that may change over time. It consists of unique name or identifier that can reference documents, images, collections of other resources or a digital representation of anything in the real world such as a person or thing.  Resources may even represent business processes and workflows.

Resource-based API's focus on the interactions across a network, independent of how they are stored in a database or manifested as objects. The provide different operations or affordances as possible interactions with a specific resource.  Resources support multiple representations that allow Web Apps, Mobile Apps and reporting tools to interact with the resource using different media formats such as JSON or XM.

### Resources are not Data Models.

It is vitally important to recognize that *resources are not the same thing as a data model*

A data model, often refelected as a schema design in a database, is optimised for the read and write operations nexessary to support the required Input/Output (I/O) operations necessary to support the required I/O performance and reporting needs of a solution.

Data operations may in fact be part of an API, the data model should not be use as the basis of the API Design.  Data models meet a specific set of requirements, including the read and write performance, data storage optimisations, query support, which mean that data models are optimised for the internal details of an application.

Web API designed directly to a data or object model expose the internal implementation details to the API consumers. This often results in fragile API's that introduce significant design changes when the underlying data model changes.

Web API's generally seek to address entirely different sets of goals including:

- Delivering outcomes and experiences
- Optimised network access
- Programming and Database independence

API's are generally used as an integration layer between systems therefore they should remain stable over long periods of time, whereas data models may change to accomodate new or changing data access requirements.

*API's may have an impact on a Data Model, they should evovle completely separately*.
