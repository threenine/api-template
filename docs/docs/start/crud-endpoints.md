---
layout: default
title: "Basic Crud Endpoints"
parent: "Getting Started"
nav_order: 3
---

# Basic Crud Endpoints template

A common requirement can occur when developing API's maybe to develop a set of Seeding or common data administration end points to populate core resources within the API for with standing data or provide a set of end points to an administration application to manage the data. These can be tedious and boring to develop because they are mostly CRUD based endpoints.

The API Template Pack provides a simple command to generate a set of basic CRUD endpoints for a given resource.  We have discussed in [What is a REST API](https://threenine.blog/posts/what-is-a-rest-api) that REST API's are all about resources and are not really to focused on CRUD operations, we understand that this is sometimes a requirement and therefore we have provided a simple command to generate these endpoints.

The basic crud endpoints will generate a set of CRUD (Create, Read, Update and Delete) endpoints, based on providing a set of criteria provided via the switch arguments.

The endpoints will not be a comprehensive list, but rather the common simple starting points to enable the quick development of really simple basic crud endpoints to enable developers to focus on the more complicated functionality.




### Switches

- *namespace* - The root namespace typically your project of company name
- *resource* - The name of the Resource we are creating.
- *model* The model we are targeting
- *domain* - The name of we're targeting

Use the  `--output` switch to define the output location for the files to be generate

The  `--name` switch to define the root folder name for the output

To generate new CRUD endpoints, assuming you have created your Model and DTO classes. You change into the `Activities` folder of your API in your terminal window. i.e.  `cd src/Api/Activities` 

```shell

dotnet new crud --name Blogs --resource Blogs --namespace Threenine --model Content --domain Article -o /src/Api/Activities
```

Everything in the API Template Pack relies heavily on namespaces for Cohesion.

This command will generate a number Files and Folders which will contain some the standard CRUD functionality for typical endpoints
separated into the `Commands` and `Queries`  [CQRS Structure](../../../introduction/cqrs-introduction)

![Crud Endpoints generated](../../../assets/images/crud-endpoints.png)


### Additional Resources

* [How to Implement Vertical Slice Architecture](https://garywoodfine.com/implementing-vertical-slice-architecture/)