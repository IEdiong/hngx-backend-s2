# HNGX API

### Introduction

HNGX API is a simple REST API capable of CRUD operations on a `person` resource.

### HNGX API Features

- Users can create a new `person`
- Get a list of people
- Get a single person
- Update a person
- Delete a person

### Installation Guide

- Clone this repository [here](https://github.com/IEdiong/hngx-backend-s2).

### Usage

- Run `dotnet run` to start the application.
- Connect to the API using Postman on port 7099.

### API Endpoints

| HTTP Verbs | Endpoints     | Action                                 |
| ---------- | ------------- | -------------------------------------- |
| POST       | /api          | To Create a new person                 |
| GET        | /api          | To retrieve all persons                |
| GET        | /api/{userId} | To retrieve details of a single person |
| PUT        | /api/{userId} | To edit the details of a single person |
| DELETE     | /api/{userId} | To delete a single person              |

### Technologies Used

- [ASP.NET Core 6.0](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0) ASP.NET Core is a cross-platform, high-performance, open-source framework for building modern, cloud-enabled, Internet-connected apps.

- [MySQL](https://www.mysql.com/) MySQL is an open-source Relational Database Management System (RDBMS) that enables users to store, manage, and retrieve structured data efficiently. It is widely used for various applications, from small-scale projects to large-scale websites and enterprise-level solutions.

- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) Entity Framework (EF) Core is a lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology. EF Core can serve as an object-relational mapper (O/RM), which enables .NET developers to work with a database using .NET objects and eliminates the need for most of the data-access code that typically needs to be written. EF Core supports many database engines, see Database Providers for details.

### Authors

- [Ediongsenyene Joseph](https://github.com/IEdiong)
