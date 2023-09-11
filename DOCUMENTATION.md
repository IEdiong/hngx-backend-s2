# HNGX API Documentation

## Introduction

Welcome to the HNGX API documentation. This API allows you to perform basic CRUD operations on a person resource. You can create, read, update, and delete records using this API.

## Base URL

The base URL for this API is: `https://api.example.com`

## Authentication

Authentication is required for any of the endpoints.


## Endpoints

### Create a `Person`

- **Endpoint:** `/api`
- **Method:** POST
- **Request Body:**
  ```json
  {
    "name": "Mark Essien",
    "email": "markessien@hng.com" (optional)
  }
```
- **Response:**
 - **Status Code:** 201 (Created)
 - **Body:**
 ```json
 {
	 "id": 1,
	"name": "Mark Essien",
	"email": "markessien@hng.com" (optional)
 }
```

### Get All `Persons`

- **Endpoint:** `/api`
- **Method:** GET
- **Response:**
 - **Status Code:** 200 (OK)
 - **Body:**
 ```json
 [
   {
	 "id": 1,
	"name": "Mark Essien",
	"email": "markessien@hng.com" (optional)
   },
   {
	 "id": 2,
	"name": "John Doe",
	"email": "johndoe@hng.com" (optional)
   }
 ]
 ```

### Get a Single `Person`



