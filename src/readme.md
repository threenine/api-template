
## Vertical Slice Architecture Api Template

In Vertical Slice Architecture, A feature manages its data access code, domain logic and its presentation code, this way we can lowering the coupling and high cohesion between features. The aim is to reduce coupling between features to only concern ourselves about a single vertical slice not N-layers, which improves maintainability. Instead of dividing code by type , kind or layer, we organise it by the change we need to make. When we need to add business functionality to an application, therefore each vertical slice should contains the minimum viable code it needs to implement its feature.

Each slice is encapsulated so that the application doesn’t need to know what goes on inside the slice—it merely passes a Request and receives a Response.

[How to Implement Vertical Slice Architecture](https://garywoodfine.com/implementing-vertical-slice-architecture/ "How to Implement Vertical Slice Architecture | Gary Woodfine")


## Package Details

This package provides an easy to implement project template to quickly and easily generate a Vertical Slice Implementation for your Api projects.

Once installed you can create new projects using the `dotnet new ` CLI commands.

The template pack provides 3 options

`Template Name         Short Name  Language  Tags`                      
`--------------------  ----------  --------  --------------------------`

`API project template  apiproject  [C#]      webapi/cqrs/vertical `     
`Command Endpoint      command     [C#]      webapi/cqrs/vertical `     
`Query Endpoint        query       [C#]      webapi/cqrs/vertical slice`

### Generate New Api Project

To create a new project use the following command

`dotnet new apiproject -n YourProjectName  -o src/`

`-n` the name for the created output. If no name is specified, the name of the current directory is used.

`-o` Location to place the generated output. The default is the current directory.

### Create a new Query Endpoint

To Generate a new Query Endpoint use

`dotnet new query  -n GetAll --Namespace MyProject.Activities.Sample.GetAll`

`-n` Name of the Endpoint you would like create
`--Namespace` The namespace you would like your End point to be in

### Create a new Command Endpoint

To Generate a new Command Endpoint use

`dotnet new command  -n Post --Namespace MyProject.Activities.Sample.Post`

`-n` Name of the Enpoint you would like create
`--Namespace` The namespace you would like your End point to be in

