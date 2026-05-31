![image alt](https://github.com/sanjayk444/Library-management-system/blob/ae314e5f2b3ea545ea8d6f2e5b90ced4194266f3/Screenshot%202026-05-31%20205613.png) 
![image alt](https://github.com/sanjayk444/Library-management-system/blob/7a7acf4957d947fd36830870aaa7ec3c4e00bcd9/Screenshot%202026-05-31%20205704.png)
![image alt](https://github.com/sanjayk444/Library-management-system/blob/d3ccc42a8b59c734e8b45527d929e5035f1eafac/Screenshot%202026-05-31%20205752.png)

A full-stack Library Management System built with **React.js**, **Tailwind CSS**, **ASP.NET Core Web API**, **Entity Framework Core**, and **SQL Server**. Designed as a portfolio-ready project demonstrating clean architecture, JWT authentication, and RESTful API design.

## Features

### Frontend (React + Tailwind CSS)
- Responsive dashboard with statistics
- Login & Registration with JWT
- Book, Member, and Transaction management
- Search, filter, pagination, and sorting
- Protected routes
- Modern UI with Tailwind CSS v4

### Backend (ASP.NET Core Web API)
- JWT Authentication & Role-based Authorization (Admin, Librarian)
- RESTful APIs with Swagger documentation
- Repository Pattern + Unit of Work
- DTO Pattern + Dependency Injection
- Global Exception Handling Middleware
- CRUD for Books & Members
- Issue/Return Book APIs with fine calculation
- Dashboard statistics API

### Database (SQL Server)
- Code First with EF Core Migrations
- Seed data (users, books, members)
- Audit fields (CreatedDate, UpdatedDate)

## Project Structure

```
LMS/
├── src/
│   ├── LibraryManagement.Domain/       # Entities, Enums
│   ├── LibraryManagement.Application/  # DTOs, Interfaces, Services
│   ├── LibraryManagement.Infrastructure/ # DbContext, Repositories, Migrations
│   └── LibraryManagement.API/          # Controllers, Middleware, Program.cs
├── client/                             # React + Vite + Tailwind
└── LibraryManagement.slnx
```

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) (or .NET 8+)
- [SQL Server](https://www.microsoft.com/sql-server) or **LocalDB** (included with Visual Studio)
- [Node.js 18+](https://nodejs.org/)

## Getting Started

### 1. Database & API

Update the connection string in `src/LibraryManagement.API/appsettings.json` if needed:

```json
"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=LibraryManagementDb;Trusted_Connection=True;TrustServerCertificate=True;"
```

Run the API (migrations and seed run automatically on startup):

```bash
cd src/LibraryManagement.API
dotnet run
```

- API: https://localhost:7102
- Swagger: https://localhost:7102/swagger

### 2. Frontend

```bash
cd client
npm install
npm run dev
```

- App: http://localhost:5173


## Tech Stack

| Layer    | Technology                          |
|----------|-------------------------------------|
| Frontend | React 19, Vite, Tailwind CSS 4      |
| Backend  | ASP.NET Core 10, EF Core 10         |
| Database | SQL Server                          |
| Auth     | JWT Bearer                          |

