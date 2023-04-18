---
layout: default
title: "Query endpoint"
parent: "Getting Started"
nav_order: 7
---
# Query Endpoint Template

The API Template guides developers down the path of implementing CQRS for REST based endpoints, as discussed in
[Introduction to CQRS](https://www.apitemplatepack.com/docs/introduction/cqrs-introduction/ "Introduction to CQRS - API Template Pack")

The query template is a great option if you want to add an additional query option to your endpoints. This template works in a similar fashion to the [Command Endpoint Template](../start/command-endpoint "Command Endpoint Template - API Template Pack")

To do so you can simply use

```shell
dotnet new query --name <name of your query> --output <Directory location to create> --resource <name of the resource>
```


## Switches

* `--name` Name of the Endpoint being created
* `--output` the output directory you would like to create
* `--resource` the name of the resource the command will be associated too
* `--force`  This is an optional command which enables overwriting some or all of the folders associated with the command.

### Example

In a similar example we defined in the [Command Endpoint Template](../start/command-endpoint "Command Endpoint Template - API Template Pack") we want to create a Read endpoint in our Email API resource.

```shell
 dotnet new query --name Read --output SampleProject/Activities/Email  --resource Email
```
Which will result in a number of folders & files being created.

![Query Created](../../../assets/images/query-success-create.png)