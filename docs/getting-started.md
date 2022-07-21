---
title: Getting Started
has_children: true
nav_order: 2
---

The API Template Pack is available as a Custom template for `dotnet new`  via nuget package.

### Installation
To install the API Template Pack you can simply do so by opening a terminal window and executing the following dotnet command line

`dotnet new -i Threenine.ApiProject`

This will install a number of Solution, Project and Item templates that you can then use to generate the items you would like to use.

Once the API Template pack is successfully installed  you should be able to use the `dotnet new -l` to list the options that will now be available.

![](images/installation.png)

#### Availalble templates

##### API Solution Template

Provides the ability to generate an entire API Solution project. Which includes:

- API Project 
- Unit & Integration test projects
- Github Action configuration
- Bitbucket Pipeline 
- Dotnet Cake Build Script

To create a new solution using the `apisolution` template simply open a terminal window and execute the command with the supplied parameters below in chosen directory

`dotnet new apisolution -n <name of your solution>  --Root <your chosen root namespace>`

- `-n`  Is a name switch that is used to provide your project a name for instance _Cms_ 
- `--Root` is a root namespace you would like to use for your project i.e. Your company name or some such.

As an example we may want to develop a Headless CMS system for our company _Threenine_ with so you can execute the command as follows:

`dotnet new apisolution -n Cms --Root Threenine`