API Project
Overview
This is a .NET Core Web API project designed to manage user data through a RESTful API. The project utilizes Data Transfer Objects (DTOs) for data encapsulation and custom middleware to handle culture-specific requests.

Table of Contents
Overview
Technologies Used
Project Structure
Setup and Installation
Data Transfer Objects (DTOs)
Middlewares
API Endpoints
Contributing
License
Technologies Used
.NET Core - A cross-platform framework for building modern, cloud-based applications.
Entity Framework Core - A lightweight, extensible, open-source ORM framework for .NET.
ASP.NET Core MVC - A web framework for building modern, cloud-based web applications.
Swagger - Tool for generating interactive API documentation.
Dependency Injection - Built-in dependency injection framework in .NET Core.
Project Structure
Copy code
API/
├── Controllers/
│   ├── UserController.cs
├── Middlewares/
│   ├── CustomCultureMiddleware.cs
├── Models/
│   └── UserDTO.cs
├── Services/
│   ├── IUserService.cs
│   └── UserService.cs
├── Repositories/
│   ├── IUserRepository.cs
│   └── UserRepository.cs
├── Program.cs
└── Startup.cs
Setup and Installation
Prerequisites
.NET SDK (version X.X or later)
SQL Server or another database.
Visual Studio or Visual Studio Code
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/yourusername/yourrepository.git
cd yourrepository
Restore NuGet packages:

bash
Copy code
dotnet restore
Apply database migrations:

bash
Copy code
dotnet ef database update
Run the application:

bash
Copy code
dotnet run
Data Transfer Objects (DTOs)
DTOs are used to transfer data between layers without exposing the internal models, ensuring a clear separation of concerns.

UserDTO Example
csharp
Copy code
public class UserDTO
{
    public int UserId { get; set; }
    public string UserName { get; set; } = null!;
    public string? Email { get; set; }
    public string PasswordHash { get; set; } = null!;
    public int? PermissionId { get; set; }
    public DateTime? CreatedAt { get; set; }
}
Middlewares
Middleware in ASP.NET Core allows you to intercept and process requests before they reach the application or before they leave the application.

Custom Culture Middleware
This middleware allows you to handle culture-specific queries.

csharp
Copy code
app.Use(async(context, next) =>
{
    var cultureQuery = context.Request.Query["culture"];
    if (!string.IsNullOrWhiteSpace(cultureQuery))
    {
        var culture = new CultureInfo(cultureQuery);
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;
    }
    await next(context);
});
Shabbat Middleware
This custom middleware can be used to enforce specific behaviors during Shabbat (a concept you might implement depending on the project requirements).

csharp
Copy code
app.useShabbat();
API Endpoints
UserController API
GET /api/user - Retrieves a list of values.
GET /api/user/{id} - Retrieves a specific value by ID.
POST /api/user - Creates a new user.
PUT /api/user/{id} - Updates a user by ID.
DELETE /api/user/{id} - Deletes a user by ID.
Example of Using DTOs
In the UserController:

csharp
Copy code
[HttpPost]
public int Post([FromBody] UserDTO value)
{
    return new USER_BL().AddNew(value);
}
Contributing
If you would like to contribute to this project, please follow these guidelines:

Fork the repository.
Create a feature branch.
Commit your changes.
Push to the branch.
Create a pull request.
License
This project is licensed under the MIT License. See the LICENSE file for details.
