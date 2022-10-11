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
- Github Action or Bitbucket Pipeline configuration
- Dotnet Cake Build Script
- Semantic Versioning
- Docker Configuration

To create a new solution using the `apisolution` template simply open a terminal window and execute the command with the supplied parameters below in chosen directory

```shell

dotnet new apisolution -n <name of your solution>  --Root <your chosen root namespace>

````

- `-n`  Is a name switch that is used to provide your project a name for instance _Cms_
- `--root` is a root namespace you would like to use for your project i.e. Your company name or some such.   
- 

#### Example solution creation using the API Template Pack

As an example we may want to develop the _Diogel_ project for our company _Threenine_ with so you can execute the command as follows:

```shell

dotnet new apisolution -n Diogel --root Threenine

```

This command will generate a full API Solution template 

```shell
.
├── bitbucket-pipelines.yml
├── build.cake
├── Diogel.sln
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
│   │   ├── DiogelContext.cs
│   │   ├── DiogelContextFactory.cs
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


### Enable version control

From the outset the API Solution template, is ready for you to start your development projects and you can start coding and implementing the business value required. However, there is one step that is required before getting started with your coding tasks - which is setting up your version control. 

#### Initiating a Git repository

By convention, a vast majority of software developers predominantly make use of [Git - Version Control](https://geekiam.io/what-is-git "What is Git - geekiam.io"). 


> The API solution makes use of Semantic Versioning and makes use of **GitVersion** which requires a Git Repository, so all you create a Git Repository by Changing into the root of your created directory and using:
> 
> `git init` 
> 
> [How to create a Git Repository](https://geekiam.io/how-to-create-git-repository "How To Create A Git Repository - geekiam.io")

The API template Pack, takes an opinionated view, on defining PostgreSQL as the default database to base API's from. We have detailed the number of [reasons why we chose PostgreSQL](../../knowledge/postgres "Why use PostgreSQL for your database - API Template Pack") as the default database option.   As such we we included a Docker-compose script that will setup a local PostgreSQL database for you.

### Opening the Solution project

You can open the Solution file in any IDE _(Intergrated Development Environment)_ that supports Dotnet Solution files this includes some of the most preferred editors in the Dotnet Community including:
* [Rider - Fast & powerful cross-platform .NET IDE](https://www.jetbrains.com/rider/ "Jetbrains Rider")
* [Visual Studio 2022 IDE - Programming Tool for Software Developers](https://visualstudio.microsoft.com/vs/ "Microsoft Visual Studio")
* [Visual Studio Code](https://code.visualstudio.com/)

The image below is a screen shot of the Solution we created open in Rider

![Solution Rider](../../../assets/images/solution-view.png)

#### Running Docker-compose to create development environment

All you need to do to get this up and running is to execute the command `docker-compose up -d` in the root directory of your project.  Alternatively, if you are using Rider you can learn [How to run docker compose files in Rider](https://garywoodfine.com/how-to-run-docker-compose-files-in-rider "How to run docker compose files in Rider - Gary Woodfine")

### Additional Resources
* [What is this Directory.Build.props file all about?](https://garywoodfine.com/what-is-this-directory-build-props-file-all-about/ "What is this Directory.Build.props file all about? - Gary Woodfine")
* [How to use Cake with Github Actions](https://garywoodfine.com/how-to-use-cake-with-github-actions/ "
  How to use Cake with Github Actions - Gary Woodfine")
* [How to run docker compose files in Rider](https://garywoodfine.com/how-to-run-docker-compose-files-in-rider/ "How to run docker compose files in Rider - Gary Woodfine")
* 

## Video

<iframe id="odysee-iframe" width="560" height="315" src="https://odysee.com/$/embed/api-solution-template/fa90baa0bca9de8d7d480b66118c62220086098c?r=DUjCQUL6MekhtSGNTPSWv8Ek7S28w12a" allowfullscreen></iframe>