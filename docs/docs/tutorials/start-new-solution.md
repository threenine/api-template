---
layout: default
title: "How to start a new API Solution"
parent: "Tutorials"
nav_order: 1
---

# How to start a new API Solution using API Template Pack

The primary objective of the API Template Pack is to enable developers to be able to quickly and easily start new API projects by attempting to automate most of the grunt work required to get a new projects up running and also to provide useful tools to automate all the boiler plate tasks, enabling developers to focus on the tasks that actually generate value.

The API Template pack enables the creation of project that utilise the best of breed solutions available in the .net ecosystem. API Template pack aims to set the projects up for you and get out of your way and enable you to focus on using the tools with them all preconfigured and ready to go. With every release of the API Template Pack we will endeavour to further improve on this mission.

Many of the decisions and configuration options that have been implemented in the API Template pack have been from our own experience that have worked well for us on projects.

The typical API Template Pack solution come preconfigured with Logging, EntityFramework, Validation, Mapping, Unit Testing tools and more. We attempt to provide an entire local Docker Compose development environment with a PostgreSQL database and Seq as your centralised logging dashboard. We will be adding more as this project continues to evolve.

### Start a new Solution

Once you have [installed the API Template Pack](../start/getting-started "Install API Template Pack") you ready to start generating your new project.

For the purpose of this tutorial we're going to assume you are working Ubuntu and using [Jetbrains Rider IDE](https://www.jetbrains.com/rider/), but the steps will be exactly the same on whichever [operating system with  .net 6 installed](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60).

The project will start developing in this walk-through tutorial is a hypothetical Headless Content Management System for a Geek News service, for a *Geekiam*.  We'll be outputting our solution to a code folder and sub directory named Cms

To start the project we'll simply use the command below, the command switches are discussed in [API Solution Template](../../start/api-solution).

```shell

dotnet new apisolution -n Cms --Root Geekiam -o code/cms

```

We can  now open our Solution file in Rider to inspect the generated projects.

![Generated Solution](../../assets/images/api-solution-view.png)

We have successfully generated our project and can set up our local develop environment we'll need to start developing.  We will need to get our preferred Database setup. API Template pack has chosen to use
PostgreSQL as our preferred database.

To get Postgres up and running is as simple as starting the Docker Compose. Our preferred means of doing is using [How to run docker compose files in Rider](https://garywoodfine.com/how-to-run-docker-compose-files-in-rider/)

Should you not want to use this method you could make use of `docker compose up -d` on your terminal.

In the current implementation this  will spin up 2 systems that the API Template pack utilises.

- [PostgresSQL database](../knowledge/postgres.md)
- [SEQ Centralised Logging](https://datalust.co/seq) 

# Connect to the Database

By default for ease of development the Database connectivity has been  defined, the Docker Compose file references a `.env` file which contain some of the connectivity, which will have the same name as your solution.

```shell
POSTGRES_USER=Cms
POSTGRES_PASSWORD=Password12@
POSTGRES_DB=Cms
PGDATA: /data/postgres
```

The `appsettings.Development.json` will have the database connection defined which will enable the application to communicate the database out the box.

```json
 "ConnectionStrings": {
    "Local_DB": "User ID=Cms;Password=Password12@;Host=localhost;Port=5432;Database=Cms;Pooling=true;Integrated Security=true;"
  },
```

For the development purposes you will probably not need to touch these settings and you will just be able  to carry on with your development.

Using Rider you will be able to connect to your Database directly in your IDE, this will come in really handy later in your Development cycle to inspect your database changes and migrations.

To connect your Database simply open the Database View and Select the '+' icon.  Search for PostgreSQL in 

![Rider Database Connect](../../assets/images/database-viewer-connect.png)

This will open a Database connection details screen, in which you should enter the details supplied in the `.env` 

![Protgres Database Connection](../../assets/images/postgres-database-connection.png)

You should be able to test your connection and it should succeed

![Test Connection](../../assets/images/postgres-database-connection-connect.png)

Once you're connected you can then go select the schemas you're going to interested in monitoring. In our case it is going to be the *Cms* but we will select all databases.

![](../../assets/images/postgres-database-connection-connect-schema.png)

### Building your Models and Database

We can now start defining our Models for our database. An Entity Framework Core model is a conceptual model of an application's domain. 

The domain includes all topics relevant to the problem solving areas of interest to the application users. The model includes data and can also include behaviour. _Typically, models for CRUD applications don't tend to incorporate a lot of behaviour_.

When developing API's we tend not to want to include any behaviours in our models, and our Models should mostly CRUD (Create, Read, Update, Delete) Focused.

The API Template Pack provides a Dedicated project to enable you to define your Models. This project is the `Models.csproj` .

Currently, by default API Template Pack attempts to pluralise your namespace for your Models and creates a folder for you to start adding your models.
 
We will add our first Model in this folder which we will name `Content`,which will primarily be Bucket for all types of Content in our system , i.e. Blog Posts, Pages, Articles etc.  All these items will primarily contain a number of the same attributes shared.

So we can simply add a C# class file and name it `Content.cs`. Once the class is created we will also now also make use of one of the features that comes with API Template Pack.  In a vast majority of cases, a Model class will need some typical attributes appended to it.  Such as an Id property, typical base audit tracking features like a Created and Modified date  and Active field to enable Soft Delete.  This will mostly need to be consistent throughout your System.

We can simplify this process by making use of the BaseEntity abstract class which has all these properties pre-defined for us. All we need to do is inherit this class in our new `Content.cs`.

BaseEntity will be in the `Threenine.Models` namespace that is already referenced in your `Models.csproj`.

```csharp
public class Content : BaseEntity
{
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Motive { get; set; }
}
```

