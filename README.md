# Vertical Slice project template
[![NuGet Badge](https://buildstats.info/nuget/threenine.ApiProject)](https://www.nuget.org/packages/threenine.ApiProject/) [![NuGet Downloads](http://img.shields.io/nuget/dt/threenine.ApiProject.svg?style=flat)](https://www.nuget.org/packages/threenine.ApiProject/)  [![Twitter Follow](https://img.shields.io/twitter/follow/threenine39.svg?style=social?maxAge=2592000)](https://twitter.com/threenine39)
[![license](https://img.shields.io/github/license/threenine/api-template?color=blue&label=license&logo=Github&style=flat-square)](https://github.com/threenine/api-template/blob/master/README.md)

A project template to get up and running quickly with the [Adralis API endpoints](https://github.com/ardalis/ApiEndpoints "ASP.NET Core API Endpoints") projects 

### Motivation

Originally a project template to accelerate the implementation of the [Adralis APi Endpoints](https://github.com/ardalis/ApiEndpoints "ASP.NET Core API Endpoints") a great framework for developing .net core web Api project and will help teams mitigate the risk of the swollen controller problem.

The problem is configuring a new project quite become a little repetitive, especially if you're a team developing a lot of microservice like API projects. This project template aims to provide everything you need to get up and running quickly.

When developing projects along these lines it became clear to me that I also started adhering to the principles of Vertical Slice Architecture and Implementing more [elements of CQRS](https://garywoodfine.com/what-is-cqrs/ "What is CQRS | Gary Woodfine") into my API projects

[Implementing Vertical Slice Architecture](https://garywoodfine.com/implementing-vertical-slice-architecture/ "Implementing Vertical Slice Architecture | Gary Woodfine") provides details of when and how to implement this project template.

## Logging
The template is configured to make use of Serilog to enable structured logging. The logging configuration options have been defined for the Development Environment to print out the Console window and can be found in the `appsettings.Development.json`  . In order to deploy production you will need to define your logging configuration in `appsettings.Production.json`

I discussed more of the details in [Implementing logging with Serilog](https://garywoodfine.com/implementing-logging-with-serilog/ "Implementing logging with Serilog | Gary Woodfine")



### Installation
To use the template simply install it using
```text
dotnet new --install Threenine.ApiProject
 ```
Will enable generating new projects using the template using
```
dotnet new apiproject -o YourProjectName
```
## Give a Star! :star:

If you like or are using this project to learn or start your solution, please give it a star. 

This helps us to understand and learn how to improve the project over time.



-----------------------------------------------------------------------------------
## Sponsored & Supported by 
[![threenine logo](http://static.threenine.co.uk/img/github_footer.png)](https://threenine.co.uk/)

