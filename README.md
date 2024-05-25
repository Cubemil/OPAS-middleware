# Application Logic with .NET Core (C#)

This is the application logic layer between the user interface and the database. \
It controls the connection between the layers as well as the correct formating and routing of the data.

## Version

ASP.NET Core in .NET 8.0

## Tooling

**Framework**
- ASP.NET Core => framework for building web applications and APIs

**API**
- RESTful APIs using ASP.NET Core Web API, will act as the bridge between the user interface and application logic, handling all requests and business logic.

**Authentication and Authorization**
- Using ASP.NET Core Identity for user authentication and authorization
- For later development stages possibly OAuth or OpenID Connect

**Extensions**
- VS Code extensions such as ESLint, Prettier for code formatting, and C# for .NET development


# Notes

- Web Server with Vue.js typically run on localhost:8080
- ASP.NET core ususally run on localhost:5000 with Kestrel or an adress like localhost:49960 with IISExpress
