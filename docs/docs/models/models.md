---
layout: default
title: "Models"
nav_order: 4
has_children: true
permalink: /docs/models
---

# Models Project

The Models project is used to define the Database Entities for the Database project, these should not be confused with 
the Domain Entities.  The Models project is tightly coupled to the Database project and the models should not be used
outside of the Database project. 

For the most part the models are a 1:1 mapping of the Database tables, however there are some exceptions to this rule. Ideally
in typical DDD fashion the *Domain Entities* would be mapped to the *Database Models* via the use of Aggregate Roots, Data Transfer
Objects, Repositories etc. 

Your classes and other objects defined in the Models project should be defined in the `Models` namespace, and this namespace
should never be used directly withing the API Project.  For the most part the Models project should be considered an internal
and the Domain and Database Project should only be able to reference it.


