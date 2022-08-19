---
layout: default
title: "What is REST"
parent: Introduction
nav_order: 8
---

# What is REST

An API, or _Application Programming Interface_, is a set of rules that define how applications or devices can connect to and communicate with each other. 

A REST-based API is an API that conforms to the design principles of the _Representational State Transfer_ software architectural style. 

This architecture style, was initially defined by Dr. Roy Fielding, and defines a software architecture style which provides a flexibility and freedom for developers to develop internet based services.

A REST based architecture, is based on 5 methods, that correspond to common CRUD (Creat, READ, Update, Delete) operations that are commonly required.

* **GET:** used to read a representation of a resource.GET typically returns a representation in XML or JSON and an HTTP response code of 200 (OK). In an error case, it most often returns a 404 (NOT FOUND) or 400 (BAD REQUEST). 
* **POST:** create new resources. On successful creation, return HTTP status 201, returning a Location header with a link to the newly-created resource with the 201 HTTP status.
* **PUT:**  used for updating resources. On successful update, return 200 (or 204 if not returning any content in the body) from a PUT. 
* **PATCH:** modifies resources. The PATCH request only needs to contain the changes to the resource.
* **DELETE:** delete a resource identified by a URI. On successful deletion, return HTTP status 200 (OK) along with a response body. 