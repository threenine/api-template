---
layout: default
title: "Basic Crud Endpoints"
parent: "Getting Started"
nav_order: 3
---

# Basic Crud Endpoints template

The basic crud endpoints will generate a whole set of CRUD (Create, Read, Update and Delete) endpoints, based on providing a set of criteria provided via the switch arguments.

### Switches

- *Namespace* - The namespace we're creating the namespace
- *Resource* - The name of the Resource we are creating.
- *Model* The model we are targeting
- *DTO* - The name of we're targeting


To generaate new CRUD endpoints, assuming you have created your Model and DTO claases. You change into the `Activities` folder of your API in your terminal window. i.e.  `cd src/Api/Activities` 

```shell

dotnet new crud --Resource Blogs --Namespace Threenine.Api.Activities.Blog  --Model  Content --DTO Article
```