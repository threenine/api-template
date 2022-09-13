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
- Semantic Versioning
- Docker Configuration

To create a new solution using the `apisolution` template simply open a terminal window and execute the command with the supplied parameters below in chosen directory

```shell

dotnet new apisolution -n <name of your solution>  --Root <your chosen root namespace>

````

- `-n`  Is a name switch that is used to provide your project a name for instance _Cms_
- `--Root` is a root namespace you would like to use for your project i.e. Your company name or some such.

As an example we may want to develop the Stop Web Crawlers API project for our company _Threenine_ with so you can execute the command as follows:

```shell

dotnet new apisolution -n SwcApi --Root Threenine

```

This command will generate a full API Solution template 

```shell
.
├── bitbucket-pipelines.yml
├── build.cake
├── SwcApi.sln
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

This will generate a full API Solution stub containing the typical project configuration for your solution. Enabling you to focus on the aspects of your project that really add value.

> The API solution makes use of Semantic Versioning and makes use of **GitVersion** which requires a Git Repository, so all you
> need to do to activate this is to create a Git Repository by Changing into the root of your created directory and using `git init`  [How to create a Git Repository](https://geekiam.io/how-to-create-git-repository "How To Create A Git Repository - geekiam.io")

### Running the generated project

The API template Pack, takes an opinionated view, on defining PostgreSQL as the default database to base API's from. We have detailed the number of [reasons why we chose PostgreSQL](../../knowledge/postgres) as the default database option.   As such we we included a Docker-compose script that will setup a local PostgreSQL database for you.

All you need to do to get this up and running is to execute the command `docker-compose up -d` in the root directory of your project.  Alternatively, if you are using Rider you can learn [How to run docker compose files in Rider](https://garywoodfine.com/how-to-run-docker-compose-files-in-rider "How to run docker compose files in Rider - Gary Woodfine")


## Video