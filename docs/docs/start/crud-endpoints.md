---
layout: default
title: "Basic Crud Endpoints"
parent: "Getting Started"
nav_order: 3
---

# Basic Crud Endpoints template

The basic crud endpoints will generate a whole set of CRUD (Create, Read, Update and Delete) endpoints, based on providing a set of criteria provided via the switch arguments.

### Switches

- *namespace* - The namespace we're creating the namespace
- *resource* - The name of the Resource we are creating.
- *model* The model we are targeting
- *domain* - The name of we're targeting

Use the `-o` or `--output` switch to define the output location for the files to be generate

The `-n` or `--name` switch to define the root folder name for the output

To generate new CRUD endpoints, assuming you have created your Model and DTO classes. You change into the `Activities` folder of your API in your terminal window. i.e.  `cd src/Api/Activities` 

```shell

dotnet new crud -n Blogs --resource Blogs --namespace Threenine.Api.Activities.Blog --model Content --domain Article -o /src/Api/Activities
```

This command will generate a number Files and Folders which will contain some the standard CRUD functionality for typical endpoints
separated into the `Commands` and `Queries`  [CQRS Structure](../../../introduction/cqrs-introduction)

![Crud Endpoints generated](../../../assets/images/crud-endpoints.png)


### Additional Resources

* [How to Implement Vertical Slice Architecture](https://garywoodfine.com/implementing-vertical-slice-architecture/)