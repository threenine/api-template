---
layout: page
title: "What is the REPR pattern"
parent: index
nav_order: 1
permalink: /what-is-repr-pattern
---

The REPR Design Pattern defines web API endpoints as having three components: 

1. Request
2. Endpoint
3. Response. 

Providing a simplified concept to enable the development REST API endpoints and enforcing the Single Responsibility Principle for endpoints.

For .net developers, the typical traditional approach to developing REST API endpoints was to make use of the MVC (Model View Controller) pattern, which inadvertently lead to a number of issues
, most notably what has become known as the _Swollen Controller Problem_ , whereby controllers usually end up with a number of disparate methods which dont't really belong together and the result is often that developers start drift from the path of developing REST Based methods and invariably end up collating a loose set of functions that are made available over Http End points.

This approach was typically promoted by Microsoft, primarily as a mechanism to try and reuse and take advantage of all the investment that they originally sunk into the ASP.net MVC.

This problem is discussed in more depth over at [Developing Api’s using Http Endpoints](https://garywoodfine.com/developing-apis-using-http-endpoints/ "Gary Woodfine")