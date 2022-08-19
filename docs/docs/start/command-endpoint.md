---
layout: default
title: "Command endpoint"
parent: "Getting Started"
nav_order: 6
---

# Command Endpoint Template

The command template is a great option if you want to add an additional Command option to your endpoints, for instance a new [Custom Method](https://www.apitemplatepack.com/docs/introduction/cqrs-introduction/#custom-http-methods)

To do so you can simply use

```shell
dotnet new command -n <name of your command> -o <Directory location to create> --Namespace <Namespace you would like to use>
```