# 🏠 Real Estate Management System

This project is a full-stack web application for managing residential properties, including houses, apartments, and residents. The system is built using **ASP.NET Core** for the backend REST API and **Angular + Bootstrap 5** for the frontend interface.

---

## Backend – ASP.NET Core Web API

### Features

- SQL database integration with EF Core
- Entity relationships between Houses, Apartments, and Residents
- Full CRUD operations for all entities
- Service-layer architecture (business logic separated from controllers)
- Database seeding
- AutoMapper integration for DTO conversion

## Frontend – Angular + Bootstrap 5

### Features

- Clean and responsive UI built with Bootstrap 5
- Full CRUD UI support for Houses, Apartments, and Residents
- Modal dialogs for editing Resident information

## Getting Started

1. **Install Required Software**:
   - [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
   - [.NET SDK](https://dotnet.microsoft.com/download)
   - [Node.js](https://nodejs.org/en)

2. **Clone the Repository**:
   ```bash
   git clone https://github.com/RalfsUpelnieks/House-managment-app.git
   ```

3. **Run the Backend**:
    - Open a terminal, navigate to the `HousingManagementAPI` folder, and run:
      ```bash
      dotnet run
      ```

5. **Run the Frontend**:
    - Open another terminal, navigate to the `house-management` folder, and install the necessary modules:
      ```bash
      npm install
      ```
    - Start the application:
      ```bash
      ng serve
      ```

6. **Visit: `http://localhost:4200`**

---