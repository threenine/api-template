---
layout: default
title: "Domain Generation template"
parent: "Getting Started"
nav_order: 4
---

# Domain Generation Template

The domain generation template enables the generation of your Domain Objects, which will particular to your individual endpoints. This template will assist in generating Domain objects for each of the essential REST Verbs:
* Delete
* Get
* Head
* Patch
* Post
* Put

We generate domain objects per _namespace_ because we want to ensure there is no **coupling** to prefer cohesion.
To generate your set of Domain objects using the following terminal command


```shell
dotnet new domain --name [ your chosen name] --output src/Domain/

```

The `--name` switch is used to define a name you would like to use
The `--output` switch is used to define the output directory, in most cases this will be within the Domain project.
