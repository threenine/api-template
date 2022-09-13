---
layout: default
title: "API Design Principles"
parent: Introduction
nav_order: 3
---

# API Design Principles

There are 5 principles to API design that should be considered in your API Design approach.

### Principle 1
**API's should never be designed in isolation**

APIs expose functionality of an application or service that exists independently of the API. The primary job of API Design should be focused on two vitally important concepts

* Understanding the important details of the application for which an API is to be created, in order to make informed decisions on what functionality needs to be exposed, how it needs to be exposed and more importantly what functionality needs to be left out.
* Modeling this functionality in an API that addresses all use cases that come up in the real world, following the [RESTful principles](what-is-rest.md) as closely as possible.

### Principle 2

**API design starts with outcome-based focus**

APIs should help developers implement important functionality with limited effort. They solve problems that matter to both business leaders and developers. Achieving API adoption requires taking ownership of our APIs by looking beyond just the technical details and thinking about how they will be used.  API's help to solve problems that matter.

API designers should be focused on understanding a specific problem and solving that problem first, before expanding the API's scope.  To help focus on these aspects you will need to understand

* **Consumption Boundaries** - Who is interacting with your API and what outcomes they expect.
* **Technical Boundaries** -  Specific technologies to mitigate risk or address specific skills required.
* **Functional Boundaries** - How the process and communication is meant to flow
* **Regulatory Boundaries** - How rules and regulations drive product considerations.

Capabilities enable developers to achieve something they previously were not able. Features are the individual steps and/or mechanisms that allow them to achieve those outcomes. API's must be able to separate what we are helping our target audience achieve (the capabilities) vs. the features that help get them there (the API endpoints). 

If you are too focused on the API design before you know what your audience is trying to achieve, your API product will fall short.

### Principle 3
**Seek to understand and apply the API elements appropriate to the need**

API Elements is a structure for describing APIs and the complex data structures used within them. It also provides structures for defining parsing results for parsing API definitions from formats like API Blueprint and Swagger/OpenAPI Format.

### Principle 4

**API documentation is the most important user interface for developers**

API documentation should be a first class citizen and not left as an after thought. Your API documentation should evolve in step
with your project. You should be detailing as much as possible about API so that all users can understand the finer points of your API. A very important metric to measure in your API is the _Time To First Call metric_ (TTFC).

In this metric you need to consider the factors influencing how much Time, Effort and Resources your customers are willing to invest in learning about your technology to make it work.  Key points to make note of here are:
* **Urgency** - Are developers actively searching for a solution to an existing problem ?  Or have they heard about your technology in passing and only have a mild curiosity in it?
* **Constraints** - Are developers trying to meet a deadline? or do they have unlimited time and budget to explore possibilities?
* **Alternatives** - Are developers required by their organisation to use your solution? or are they trying to choose the best appropriate solution from many providers?

As a publisher of an API, you should be focusing on streamlining your TTFC results and focus on ensuring that developers have all the information they need to understand and use your API in the minimum amount of time.  Streamlining TTFC results in a larger market potential of better-educated users for the later stages of your developer journey.

### Principle 5

**API's are forever**

Once you publish your API and customers start using then they will be in use forever, so you need to plan accordingly. A thoughtful API design combined with an evolutionary design approach makes API's resilient to change.

