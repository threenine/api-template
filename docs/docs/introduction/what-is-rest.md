---
layout: default
title: "What is REST"
parent: Introduction
description: "A REST-based API is an API that conforms to the design principles of the Representational State Transfer software architectural style"
image: "../../../assets/images/twitter/repr-pattern.png"
nav_order: 8
---

# What is REST

An API, or _Application Programming Interface_, is a set of rules that define how applications or devices can connect to and communicate with each other. 

A REST-based API is an API that conforms to the design principles of the _Representational State Transfer_ software architectural style. 

This architecture style, was initially defined by Dr. Roy Fielding, and defines a software architecture style which provides a flexibility and freedom for developers to develop internet based services.

A REST based architecture, is based on 5 methods, that correspond to common CRUD (Creat, READ, Update, Delete) operations that are commonly required.

### Request and Response

The core concept behind REST is that it primarily a Request & Response style interaction, commonly referred to as the [REPR Pattern](https://www.apitemplatepack.com/docs/introduction/repr-pattern/ "REPR Pattern - API Template Pack").

A _HTTP Request_ generally consists of: 

* an HTTP verb, which defines what kind of operation to perform
* a header, which allows the client to pass along information about the request
* a path to a resource
* an optional message body containing data

_HTTP Response_ sent by a server to the client. The response is used to provide the client with the resource it requested. It is also used to inform the client that the action requested has been carried out. It can also inform the client that an error occurred in processing its request.

An _HTTP response_ contains the following things:

* Status Line
* Response Header Fields or a series of HTTP headers
* Message Body

### HTTP Verbs
* **GET:**  used to read a representation of a resource.GET typically returns a representation in XML or JSON and an HTTP response code of 200 (OK). In an error case, it most often returns a 404 (NOT FOUND) or 400 (BAD REQUEST). 
* **POST:**  create new resources. On successful creation, return HTTP status 201, returning a Location header with a link to the newly-created resource with the 201 HTTP status.
* **PUT:**   used for updating resources. On successful update, return 200 (or 204 if not returning any content in the body) from a PUT. 
* **PATCH:**  modifies resources. The PATCH request only needs to contain the changes to the resource.
* **DELETE:**  delete a resource identified by a URI. On successful deletion, return HTTP status 200 (OK) along with a response body. 

### Advantages of REST 

* Simple and familiar to most developers
* Provides the ability to test an HTTP API within a browser, command line using Curl or even browser based plugins like [Postman](https://www.postman.com/) or [insomnia](https://insomnia.rest/)
  * Support [Request/Response style](https://www.apitemplatepack.com/docs/introduction/repr-pattern/) communication 
  * Firewall friendly
  * Simple Architecture

### Disadvantages of REST

* Only supports Request/Response style of communication
* Reduced availability
* Clients need to know the URL locations
* Fetching multiple resources in a single response is challenging
* Difficult to map multiple update operations to HTTP verbs.