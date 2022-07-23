---
layout: default
title: "Why use PostgreSQL for your database"
parent: "Knowledge"
nav_order: 1
---

# Why use PostgreSQL for your database

There are a number of database management systems to choose from, form Document Database Systems to Relational Database Management (RDBMS).   if the relational model best represents your data, then PostgreSQL is one of the most popular and well-regarded open-source relational databases in the world.

This article will cover some of the primary reasons so many developers choose PostgreSQL for their data management needs. These range from feature availability and standards compliance to community support and project governance.

## Rich Feature Set

One of the primary reasons for choosing to use PostgreSQL is its large list of features. PostgreSQL possesses an incredible number of features related to performance, security, programming extensions, and configuration among others.

Some of the features that PostgreSQL offers include:

Support for writing database functions using:
- SQL
- Tcl
- Perl
- Python
- Java
- Lua
- R
- shell
- JavaScript

### Datatypes

Postgres provides support for a large number of data types out the box
- common database primitives like `numeric`, `string`, `boolean`, and `datetime` types: These are found in most databases and have great support in PostgreSQL.
- [network addresses](https://www.postgresql.org/docs/current/datatype-net-types.html): PostgreSQL supports various network-related types like CIDR addresses, addresses with subnet masks, and MAC addresses, both for IPv4 and IPv6.
- [geometric types](https://www.postgresql.org/docs/current/datatype-geometric.html): A variety of types are available to help you define two dimensional objects. These include points, lines, and, segments, as well as complete shapes like boxes, polygons, and circles.
- [monetary types](https://www.postgresql.org/docs/current/datatype-money.html): PostgreSQL's money type stores currency at fixed fractional precision. The type locale-aware and includes automatic output formatting.
- ranges: Ranges allow you to work natively with ranges of values like, for example, date and time ranges for scheduling.
- [JSONB](https://www.postgresql.org/docs/current/datatype-json.html): PostgreSQL's native support for storing and operating on JSON objects can help you work with both relational and non-relational data in the same system.
- [hstore](https://www.postgresql.org/docs/current/hstore.html): The hstore type allows you to work with key-value pairs natively.
multidimensional arrays: Arrays are very useful for storing multi-part values that don't have much meaning outside of their specific context.

Along with these rich sets of datatypes Postgres provides support for you to [define your own complex types](https://www.postgresql.org/docs/current/sql-createtype.html). Defining your own types helps you align your database more closely with the way your data is represented in your applications.

[Full-text search](https://www.postgresql.org/docs/current/textsearch.html): Full-text search gives you powerful techniques for finding and operating on data in semi- and unstructured text. Search can be fine-tuned to match your expectations for relevancy and matching.

Robust [authentication](https://www.postgresql.org/docs/current/auth-methods.html), [access control](https://www.postgresql.org/docs/current/user-manag.html), and [privilege management](https://www.postgresql.org/docs/current/ddl-priv.html) systems suitable for organizations of any size: PostgreSQL has mature user authentication and authorization functionality to define who can use the system and what each user is allowed to see or do.

[Foreign data wrappers](https://www.postgresql.org/docs/current/postgres-fdw.html): Foreign data wrappers make it possible to represent and access tables and data in remote servers.

[Views](https://www.postgresql.org/docs/current/sql-createview.html) and [materialized views](https://www.postgresql.org/docs/current/rules-materializedviews.html): Support for views and materialized views allow convenient, simplified access to data by abstracting the original table structures for information that is frequently queried for together.

[Comments on database objects](https://www.postgresql.org/docs/current/sql-comment.html): The ability to attach comments on tables, databases, columns, and other individual database objects allows you to document decisions or implementation details.

[Write-Ahead Logging](https://www.postgresql.org/docs/current/wal-intro.html) to provide [point-in-time recovery](https://www.postgresql.org/docs/current/continuous-archiving.html), [failover](https://www.postgresql.org/docs/current/warm-standby-failover.html), and [streaming replication](https://www.postgresql.org/docs/current/warm-standby.html): These technologies help ensure that your database remains consistent even if the software crashes, and helps you copy data between systems for scaling and backing up data.

### Object Oriented Database

One of the most fundamental ways that PostgreSQL is different from most other relational databases comes from its core design.

Most relational databases are best described as Relational Database Management Systems (RDBMSs). RDBMSs are software specifically designed to handle relational databases, where data is stored in table-like structures with predefined columns and data types. Data can be queried, modified, and retrieved using techniques based on relational algebra, usually through structured query language (SQL).

PostgreSQL, is technically an [Object-Relational Database Management System (ORDBMS)](https://en.wikipedia.org/wiki/Object%E2%80%93relational_database). This means that it has the same relational capabilities as an RDBMS, but additionally has some object-oriented features.