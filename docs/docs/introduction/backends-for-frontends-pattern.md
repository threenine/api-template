---
layout: default
title: "Backends for Frontends pattern"
parent: Introduction
nav_order: 9
description: "A BFF is a dedicated backend for the frontend, which proposes proposes a server-side component for each front-end application, thus enhancing and improving the user experience."
image: "../../../assets/images/5-principles-api-design.png"
---
## Backends for Frontends Pattern

The **Backends for Frontends pattern (BFF)** is an fairly recent emerging pattern that is becoming more popular with the rise of mobile and web applications.  The pattern is a variation of the [Microservices Architecture Pattern](https://www.apitemplatepack.com/docs/introduction/microservices-architecture/ "Microservices Architecture Pattern - API Template Pack") and is used to help address the challenges of developing and maintaining multiple client applications that are used to access the same backend services.


### What is the Backends for Frontends Pattern?

A BFF is a dedicated backend for the frontend, which proposes proposes a server-side component for each front-end application, thus enhancing and improving the user experience. The server is responsible for translating communication between domain services and the frontend, easing the work on the frontend.

A BFF layer comprises multiple back-ends that are designed to meet the demands of specific front-end applications, such as desktop, browser, and native-mobile applications. One of the most appealing aspects of BFF is that it provides smooth user interaction independent of the platform on which the front-end application executes.

Back-end-for-front-end is an architectural paradigm, a variant of the API gateway pattern, with each client application having its corresponding back-end application. This pattern is good when you have multiple client interfaces with diverse needs, leveraging the same underlying resources. 



### Why use the Backends for Frontends Pattern?

A typical real-world example of the BFF pattern is an application that may have both a Web & mobile clients.

### When to use the Backends for Frontends Pattern?

You should use this pattern when you have multiple client interfaces that need to access the same backend services and when your consumers need to consume data that requires a lot of aggregation on the back-end code, by incorporating customizations to the general-purpose back-end code to serve multiple interfaces.

You should also use BFF if you would like to optimize the back-end code so that it can satisfy the requirements of specific client interfaces.

### What are the benefits of the Backends for Frontends Pattern?

#### Simplified Client Applications
The BFF Pattern reduces the "chattiness" of the client applications by providing a single point of access to the backend services by serving as as an aggregation layer and coordinating the communication between the client and the backend services.


#### Aggregation Layer
The BFF enables Smaller and less computationally intensive client applications, by functioning as a request aggregator and reducing the number of requests to the backend services. This is achieved by combining multiple requests into a single request to the backend services. This is especially useful when the client application is a mobile application, as mobile devices have limited resources and bandwidth can be expensive.

#### Enhanced security

Taking advantage of the BFF pattern to hide sensitive information while sending the response back to the client. Additionally, this abstraction makes it extremely difficult for intruders to compromise your sensitive data.

#### Faster to market
Faster time to market for new client applications, as frontend teams serving their unique needs.  Instead of waiting for the back-end team to build the API, the client development team has complete control, allowing it to be at the forefront of the delivery schedule.



### Resources

* [Building Microservices: Designing Fine-Grained Systems 2nd Edition by Sam Newman](https://amzn.to/3V0akJk "Building Microservices: Designing Fine-Grained Systems 2nd Edition by Sam Newman")
* [Microservices Patterns: With examples in Java by Chris Richardson](https://amzn.to/3oxWq5b "Microservices Patterns: With examples in Java by Chris Richardson")