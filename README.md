#   API Project


## Overview
This .NET Core Web API project is designed to manage user data through a RESTful API. It leverages Data Transfer Objects (DTOs) for encapsulation and custom middleware to handle culture-specific requests.

###  Technologies Used
.NET Core
Entity Framework Core (Version 6.0.0)
Swashbuckle.AspNetCore (Version 6.5.0)
ASP.NET Core MVC
Dependency Injection


### Project Structure

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


### Setup and Installation

.NET SDK

SQL Server or another database

Visual Studio or Visual Studio Code


#License
This project is licensed under the MIT License. See the LICENSE file for details




