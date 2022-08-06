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





