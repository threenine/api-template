---
layout: default
title: "Database project template"
parent: "Getting Started"
nav_order: 8
---

# Database project template

The Database project template aims to make creating a new database project for your microservice is as easy as possible. Bu default the project is configured to generate MSSQL, however if
you want to use PosgreSQL you can make use of the `--usePOSGRE` switch to generate for
postgre

```shell
dotnet new database --name [Name of your Database]  --output [output location]
```

To generate for Postgre you can use the same same command just passing in `--usePOSGRE` switch

```shell
dotnet new database --name [Name of your Database]  --output [output location] --usePOSTGRE
```


### Additional switches
* `--name` Name of your class to be created
* `--output` The preferred output location
* `--usePOSTGRE`  optional flag to create a new solution that uses a PostgreSQL database backend
* `--force`  Forces content to be generated even if it would change existing files. This is required when the template
  chosen would override existing files in the output directory.


Using Rider project wizard 

![Database project](../../assets/images/database-project.png)

