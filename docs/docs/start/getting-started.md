---
title: "Getting Started"
layout: default
nav_order: 2
has_children: true
permalink: /docs/getting-started
---
# Getting Started with API Template Pack

Creating a resilient, stable and secure REST API's is a difficult task, and many of the tasks you'll need to perform are quite repetitive and can be error prone if completed incorrectly.  The API Template pack aims to minimise the need to carry out these tasks, enabling you to only focus on the tasks that add real business value quickly.

The API Template Pack is available as a Custom template for `dotnet new`  via a nuget package. 

[Custom templates](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates) enable you to install from a NuGet package on any NuGet feed, by referencing a NuGet `.nupkg` file directly, or by specifying a file system directory that contains the template.

### Installation

To install the API Template Pack you can simply do so by opening a terminal window and executing the following [dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new-install) command line.

```shell

dotnet new -i Threenine.ApiProject

```

This will install a number of Solution, Project and Item templates that you can then use to generate the items you would like to use.

Once the API Template pack is successfully installed  you should be able to use the `dotnet new -l` to list the options that will now be available.

![Installation screen](../../assets/images/installation.png)


### Uninstall 

Should for you for whatever reason need to uninstall the API Template pack this can be achieved by simply executing
```shell

dotnet new -u Threenine.ApiProject

```

<iframe id="odysee-iframe" width="560" height="315" src="https://odysee.com/$/embed/api-template-pack-install/f2e725223b40144f7b6b77c9601120946fa3d303?r=DUjCQUL6MekhtSGNTPSWv8Ek7S28w12a" allowfullscreen></iframe>