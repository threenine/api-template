---
layout: default
title: "Vertical Slice Architecture"
parent: Introduction
nav_order: 3
---

# What is Vertical Slice Architecture

The Vertical Slice Architecture (VSA) is a technique that helps developing maintainable applications by separating the application around Features, Activity or Vertical Slice. 

This practice is influenced by an Agile project management practice of **Vertical Slicing**, where a work item is slimmed donw to a narrow focus. In other works, breaking the work into smaller pieces. Yet, the pieces have all the functions to be stand-alone. It may or may not require more features to be truly useful. However, as a piece of the system, it works on it's own.

The key concept to note is that you will need all pieces of the system components to be included, so that the work can function with this piece of work.

Ultimately, Vertical Slicing is a process of breaking work up, splitting up larger functionalut into more bite-sized pieces of work. Work that an Agile Sosftware development team can go execute on. This also ensures that once executed, it could be completed and the business or system gain value from it.
 
In the software developmnet approach we think of the application code in terms of features rather than the specific layer that it sits in. We treat each feature as a vertical slice, because every feature within the application is a separate component and it change change and evolve independently.

When developing applications using this approach we consider every request and response as distinct use cases. Taking this a step further and thinking about REST API' we can further break the Requests into either **Queries** or **Commands**, which ultimately is also derived from **CQRS (Command Query Responsiblity Segregation)** 

![Vertical Slice](../../../assets/images/vertical-slice.png)

A feature or slice covers all the layers of a traditional architecture design and instead of coupling across a layer, we couple along the “slice”. The aim is to **maximize cohesion in the slice while minimizing coupling between the slices**.

### Advantages of Vertical Slice Architecture

#### Reduce coupling

Using Vertical Slice Architecture, we reduce coupling between features. Focusing on a single slice while implementing a feature rather than different layers, thus improving maintainability.

#### External Interactivity

Each slice is independent and able interact with external resources. Different slices using distinct ways to persist data without interfering with each other.

#### Command and Query Responsibility Segregation

Application code split between the Queries and Commands. This segregation helps us to treat each feature as a distinct use case.  Queries are typically **GET** or Read data, while Commands are typically **POST, PUT PATCH, DELETE** or Write data to a store.

#### Feature Grouping

Enforcing high cohesion within a slice, code for the feature is only used by the feature. This leads to ease of implementation and maintainability.

### Additional Resources

- [Vertical Slice Architecture - Jimmy Bogard](https://jimmybogard.com/vertical-slice-architecture/ "Vertical Slice Architecture - Jimmy Bogard")
- [How to Implement Vertical Slice Architecture - Gary Woodfine](https://garywoodfine.com/implementing-vertical-slice-architecture/ "How to Implement Vertical Slice Architecture - Gary Woodfine")