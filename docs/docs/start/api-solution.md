---
layout: default
title: "API Solution Template"
parent: "Getting Started"
nav_order: 1
---
# API Solution Template

Provides the ability to generate an entire API Solution project including:

- API Project
- Unit & Integration test projects
- Github Action configuration
- Bitbucket Pipeline
- Dotnet Cake Build Script

To create a new solution using the `apisolution` template simply open a terminal window and execute the command with the supplied parameters below in chosen directory

```shell

dotnet new apisolution -n <name of your solution>  --Root <your chosen root namespace>

````

- `-n`  Is a name switch that is used to provide your project a name for instance _Cms_
- `--Root` is a root namespace you would like to use for your project i.e. Your company name or some such.

As an example we may want to develop a Headless CMS system for our company _Threenine_ with so you can execute the command as follows:

```shell

dotnet new apisolution -n Cms --Root Threenine

```

This command will generate a full API Solution template 

```shell
.
├── bitbucket-pipelines.yml
├── build.cake
├── Cms.sln
├── Directory.Build.props
├── docker-compose.yml
├── Dockerfile
├── .github
│   └── workflows
│       └── cake-build.yaml
├── .gitignore
├── GitVersion.yml
├── README.md
├── src
│   ├── Api
│   │   ├── Activities
│   │   ├── Api.csproj
│   │   ├── appsettings.Development.json
│   │   ├── appsettings.json
│   │   ├── Behaviours
│   │   ├── Exceptions
│   │   ├── Helpers
│   │   ├── Middleware
│   │   ├── Program.cs
│   │   ├── Properties
│   │   └── README.md
│   ├── Database
│   │   ├── appsettings.json
│   │   ├── CmsContext.cs
│   │   ├── CmsContextFactory.cs
│   │   ├── Configurations
│   │   ├── Database.csproj
│   │   └── README.md
│   ├── DTOs
│   │   ├── Dto1.cs
│   │   └── DTOs.csproj
│   └── Models
│       ├── Cmss
│       └── Models.csproj
└── tests
    ├── Integration
    │   ├── Asserts
    │   ├── Integration.csproj
    │   └── Tests
    └── Unit
        └── Unit.csproj

```