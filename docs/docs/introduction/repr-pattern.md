---
layout: default
title: "REPR pattern"
parent: Introduction
nav_order: 4
---
# What is the REPR design pattern

The REPR pattern is a software design pattern for developing API Endpoints implementing a simple _Request EndPoint Response_ flow.

![REPR Pattern](../../../assets/images/repr-pattern.png)

The REPR Design Pattern defines web API endpoints as having three components: 

1. **Request**  - The shape of the data the endpoint expects
2. **Endpoint** - Logic the endpoint performs given a request
3. **Response** - The shape of the data the endpoint returns

Providing a simplified concepts to enable the development REST API endpoints and enforcing the _Single Responsibility Principle_ for endpoints. The only Models that
the Developers need to care about are the Request and Response.

Not all endpoints will require data for their Request or Response, in some cases taking in no inputs or returning just an HTTP status code. But an empty request or response is still a valid one in this pattern.

## Why the REPR pattern

For .net developers, the typical traditional approach to developing REST API endpoints was to make use of the MVC (Model View Controller) pattern, which inadvertently lead to a number of issues, most notably what has become known as the _Swollen Controller Problem_ , whereby controllers usually end up with a number of disparate methods which dont't really belong together and the result is often that developers start drift from the path of developing REST Based methods and invariably end up collating a loose set of functions that are made available over Http End points.

This approach was typically promoted by Microsoft, primarily as a mechanism to try and reuse and take advantage of all the investment that they originally sunk into the ASP.net MVC.

### Additional Resources

- [Developing Api’s using Http Endpoints](https://garywoodfine.com/developing-apis-using-http-endpoints/ "Gary Woodfine")
- [MVC Controllers are Dinosaurs - Embrace API Endpoints](https://ardalis.com/mvc-controllers-are-dinosaurs-embrace-api-endpoints/ "Ardalis")