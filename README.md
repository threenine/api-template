# API Endpoint project template

A project template to get up and running quickly with the [Adralis API endpoints](https://github.com/ardalis/ApiEndpoints "ASP.NET Core API Endpoints") projects 

### Motivation

Adralis APi Endpoints is great framework for developing .net core web Api project and will help teams mitigate the risk of the swollen controller problem.

The problem is configuring a new project quite become a little repetitive, especially if you're a team developing a lot of microservice like API projects. This project template aims to provide
everything you need to get up and running quickly.


## Logging
The template is configured to make use of Serilog to enable structured logging. The logging configuration options have been defined for the Development Environment to print out the Console window
and can be found in the `appsettings.Development.json`  . In order to deploy production you will need to define your logging configuration in `appsettings.Product.json`



[![threenine logo](http://static.threenine.co.uk/img/github_footer.png)](https://threenine.co.uk/)