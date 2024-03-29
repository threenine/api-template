---
title: "Change log"
layout: default
nav_order: 8
permalink: /docs/changelog
---

# Change log

### 6.1.0 

* Refactor and improvements to the Database project template - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Implement Dependency Injection capability to the database projects to enable inversion of control the net result is now
there are two new calls to make when wanting to add the Database project you API Solution.  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated documentation to incorporate these changes  - [@gary_woodfine](https://twitter.com/gary_woodfine)


### 6.0.0
* Updated to .Net 8.0 - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Upgraded project dependencies - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated make use of C# Language syntax enhancements - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Created Connection String Names Static Class - [@gary_woodfine](https://twitter.com/gary_woodfine)
* 

### 5.0.0
* Updated to .Net 7.0 - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Upgraded project dependencies - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated Documentation with Backend For Frontend Pattern explanation - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated Documentation with Microservices Architecture Pattern explanation - [@gary_woodfine](https://twitter.com/gary_woodfine)
* 

### 4.1.7

### Enhancement

* Removed the Root Namespace parameter on Command And Query templates  - [@gary_woodfine](https://twitter.com/gary_woodfine)

### 4.1.5

### Enhancement

* Command & Query template updated with lowercasing of parameters and improved folder layout. - [@gary_woodfine](https://twitter.com/gary_woodfine)

### Documentation 

* Updated Command & Query Template with improved instructions on how to make use of them - [@gary_woodfine](https://twitter.com/gary_woodfine)


### 4.1.4

### Bug 

* Fixed issue with CRUD endpoint generation, Namespace conflicts were being created. - [@gary_woodfine](https://twitter.com/gary_woodfine)

### Documentation

* Provided additional detail on how to make use of the CRUD endpoint generation - [@gary_woodfine](https://twitter.com/gary_woodfine)

### 4.1.3

### Bug

* Fixed issue with Github upgrading to Cake 3.0 DotnetCore* settings stopped working, updated cake scripts - [@gary_woodfine](https://twitter.com/gary_woodfine)

### 4.1.2

#### Documentation

* Fixed issue with the Models and Domain modelling menu options referring to the same item  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated more details to the Entity Type Configuration - [@gary_woodfine](https://twitter.com/gary_woodfine)

#### Enhancement

* Added a Common Project which can be used to share common constants, methods and properties for all projects - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Moved Regular Expressions to Common project - [@gary_woodfine](https://twitter.com/gary_woodfine)
* 

### 4.1.1 

#### Administration

* Added Funding option to enable Sponsorship of the project - [@gary_woodfine](https://twitter.com/gary_woodfine)

### 4.1.0

#### Feature

* Added Database project template to be able to add Databases to existing API Projects - [@gary_woodfine](https://twitter.com/gary_woodfine)

#### Enhancement

* Added Entity Validation functionality in database projects as per [Entity Validation to database projects](https://github.com/threenine/api-template/discussions/20) - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated [Threenine.Dataservice](https://www.nuget.org/packages/threenine.Dataservice/) reference to enable functionality -  [@gary_woodfine](https://twitter.com/gary_woodfine)

### Documentation

* Implemented Mermaid within the documentation theme in order to be able to create useful diagrams in documentation -  [@gary_woodfine](https://twitter.com/gary_woodfine)
* Added and created initial version of the Domain project documentation - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Added Database project template documentation - [@gary_woodfine](https://twitter.com/gary_woodfine) 
* Tidied up style sheet on hover links - [@gary_woodfine](https://twitter.com/gary_woodfine)
### 4.0.2   

**Breaking changes**

#### Enhancement

* Renaming of the `DTOs` project to `Domain` this is inline with discussion item detailed on Github [Creating Database Folder for Database project](https://github.com/threenine/api-template/discussions/16) - [@gary_woodfine](https://twitter.com/gary_woodfine)

### Feature

* Added Model Configuration Template for issue [#19](https://github.com/threenine/api-template/issues/19) - [@gary_woodfine](https://twitter.com/gary_woodfine)


#### Documentation Updates

* Renamed DTO generation to Domain Generation
* Added Model Configuration documentation

### 3.2.96

#### Bug

* Remove NUGET_API_KEY from Github Action environment variable configuration on Solution Template because this is not required and is carry over from the initial configuration when we started the project - [@gary_woodfine](https://twitter.com/gary_woodfine)
* 
#### Feature

* Added Docker Container Build and Publish steps to Cake Build script - [@gary_woodfine](https://twitter.com/gary_woodfine)

#### Documentation Update

* Added Build section to documentation - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Provided introduction to Cake - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Added detail regarding REST  - [@gary_woodfine](https://twitter.com/gary_woodfine)



### 3.2.95

#### Feature

* Added UUID Generation extension to Postgres Dataconext to enable uuid for database - [@gary_woodfine](https://twitter.com/gary_woodfine)



### 3.2.94

#### Feature

* Set Root parameter to be lower case on api solution template after request from users who prefer all arguments to be lowercase on terminal commands as that fits in with typical industry standards. - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated Behaviour event handlers to conform to latest Mediatr library -[@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated Project Library references -[@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated Project behaviour handlers -[@gary_woodfine](https://twitter.com/gary_woodfine)

#### Documentation Updates

* Update to documentation for the root parameter  - [@gary_woodfine](https://twitter.com/gary_woodfine)

#### Bug

* Renamed folder in Models project to be **Data** because to enable different types of Models to be created - [@gary_woodfine](https://twitter.com/gary_woodfine)

#### Documentation Updates

* Tweak to Twitter Card images - [@gary_woodfine](https://twitter.com/gary_woodfine)
* 

### 3.2.91

#### Documentation Updates

* Tweak to Twitter Card images - [@gary_woodfine](https://twitter.com/gary_woodfine)


### 3.2.90

#### Documentation Updates

* Updating Meta Descriptions for all documentation pages to improve SEO- [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updating Twitter Card for pages to improve SEO and sharing - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Added logo image to Readme  [@gary_woodfine](https://twitter.com/gary_woodfine)

### 3.2.89 
  
#### Documentation Updates
* Removed magic strings from the ContextFactory to make use of Internal Constants  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated Documentation to include details about how to make use of the Database project  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Updated REPR pattern image in documentation  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Added Change log to inform of release updates  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Update Read me's  with link to change log  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Update library references in the API Solution Template  - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Started Models project documentation - [@gary_woodfine](https://twitter.com/gary_woodfine)
* Added Twitter Card to front page - [@gary_woodfine](https://twitter.com/gary_woodfine)


