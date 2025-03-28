# JSShopAPI - .NET Core Studnet and E-Commerce API

## Overview
JSShopAPI is a .NET Core-based e-commerce API that provides a backend solution for managing user registration, login, and listing items. The project integrates Swagger for API documentation and uses ADO.NET for database interactions.

## Features
- User authentication and authorization using token authentication in the header
- User registration and login functionality
- Product listing API
- Secure API endpoints with role-based access control
- Database integration with ADO.NET

## Technologies Used
- **.NET Core 8.0** - Backend framework
- **ADO.NET** - Database connectivity
- **SQL Server** - Primary database
- **Token-based Authentication** - Secure user authentication
- **Swagger** - API documentation
- **ASP.NET Core Web API** - API development

## Getting Started
### Prerequisites
Ensure you have the following installed:
- .NET SDK 8.0
- SQL Server
- Visual Studio / VS Code

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/jssuthahar/DotnetCore.git
   cd DotnetCore/JSShopAPI
   ```
2. Set up the database:
   - Replace the connection string in `appsettings.json` with your database details.
   - Create the required table by executing the following SQL query:
     ```sql
     CREATE TABLE Student (
         id INT PRIMARY KEY IDENTITY(1,1),
         FullName NVARCHAR(255) NOT NULL,
         Email NVARCHAR(255) NOT NULL UNIQUE,
         Password NVARCHAR(255) NOT NULL,
         role INT NOT NULL
     );
     ```

3. Run the application:
   ```bash
   dotnet run
   ```
4. Access the API:
   - API documentation is available at `http://localhost:<port>/swagger`

## API Endpoints
### Authentication
- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Login and get an authentication token

### Products
- `GET /api/products` - Get all products (Requires authentication token in header)

### Using Token Authentication
After logging in, include the token in the `Authorization` header for authenticated requests:
```http
Authorization: Bearer <your_token_here>
```

## Contributing
Contributions are welcome! Feel free to open issues or submit pull requests.


