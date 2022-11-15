---
layout: default
title: "API Project Template"
parent: "Getting Started"
nav_order: 2
---

# API Project Template

If you already have an existing solution and you just need to add an API Project to it, the API Project Template enables this by executing

```shell

dotnet new apiproject -n <name of your project> 

```

The API Project template will just create an API project that can be used in any solution enabling you to develop an API project following the [Vertical Slice Architecture](../introduction/vertical-slice "Vertical Slice Architecture") and [REPR Pattern](../introduction/repr-pattern "REPR Pattern") with a project all ready preconfigured with:
* Automapper
* mediatr
* FluentValidation
* Ardalis API Endpoints
* Dotnet
* Threenine.Data
* Entity Framework
* Serilog
* PostgreSQL

Ready for you to start coding your new API Endpoints.
