# DEPI System API

## Overview
The **DEPI System API** is a backend service designed to manage DEPI operations efficiently. Built using the **N-Tier architecture** and the **Generic Repository pattern**, it follows **RESTful principles** to ensure scalable, maintainable, and modular development.

## Features
- **N-Tier Architecture**: Ensures separation of concerns for better maintainability.
- **Generic Repository Pattern**: Promotes reusability and clean data access.
- **RESTful APIs**: Standardized communication between client and server.
- **Entity Management**: Handles entities like Students, Groups, Instructors, Courses, Tracks, and Fields.
- **Authentication & Authorization** (Planned): Secure API endpoints using JWT.
- **Logging & Exception Handling**: Ensures debugging and stability.
- **Database Integration**: Supports SQL-based databases (e.g., SQL Server, PostgreSQL).

## Technologies Used
- **.NET Core**
- **Entity Framework Core**
- **ASP.NET Web API**
- **SQL Server**
- **Swagger** (for API documentation)

## Installation & Setup
```sh
# Clone the repository
git clone https://github.com/eslams3dawi/DEPI-System-API.git
cd DEPI-System-API

# Install dependencies
dotnet restore

# Configure the database connection in appsettings.json

# Run database migrations (if using EF Core)
dotnet ef database update

# Start the API
dotnet run
```
