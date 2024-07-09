# Employee Management API

A RESTful API for managing employee information, built with .NET 6. This API allows you to create, read, update, and delete employee records in a SQL Server database.

## Features

- **Retrieve all employees**: GET `/employees`
- **Fetch an employee by ID**: GET `/employees/{id}`
- **Create a new employee**: POST `/employees`
- **Update an existing employee**: PUT `/employees/{id}`
- **Delete an employee**: DELETE `/employees/{id}`

## Technologies Used

- .NET 6
- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger for API documentation

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. **Clone the repository**:

    ```sh
    git clone https://github.com/yourusername/EmployeeManagementAPI.git
    cd EmployeeManagementAPI
    ```

2. **Set up the database**:
   - Ensure SQL Server is running.
   - Update the connection string in `appsettings.json` to match your SQL Server configuration.

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=true"
      }
    }
    ```

3. **Apply Migrations and Create Database**:

    ```sh
    dotnet ef database update
    ```

4. **Run the application**:

    ```sh
    dotnet run
    ```

5. **Access the API documentation**:
   - Open your browser and navigate to `http://localhost:5109/swagger/index.html` (adjust the port if necessary).

## Usage

### API Endpoints

- **GET /employees**: Retrieves a list of all employees.

    Example:
    ```sh
    curl -X GET "http://localhost:5109/employees" -H "accept: application/json"
    ```

- **GET /employees/{id}**: Fetches details of a specific employee by their ID.

    Example:
    ```sh
    curl -X GET "http://localhost:5109/employees/1" -H "accept: application/json"
    ```

- **POST /employees**: Creates a new employee in the system.

    Example:
    ```sh
    curl -X POST "http://localhost:5109/employees" -H "accept: application/json" -H "Content-Type: application/json" -d "{ \"firstName\": \"Obsu\", \"middleName\": \"A.\", \"lastName\": \"kebede\"}"
    ```

- **PUT /employees/{id}**: Updates an existing employee's information by their ID.

    Example:
    ```sh
    curl -X PUT "http://localhost:5109/employees/1" -H "accept: application/json" -H "Content-Type: application/json" -d "{ \"firstName\": \"obsu\", \"middleName\": \"B.\", \"lastName\": \"kebede\"}"
    ```

- **DELETE /employees/{id}**: Deletes an employee from the system by their ID.

    Example:
    ```sh
    curl -X DELETE "http://localhost:5109/employees/1" -H "accept: application/json"
    ```

## Project Structure

- **Controllers**: API endpoints for employee management.
- **Data**: Database context and migration files.
- **Repositories**: Repository pattern implementation for data access.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Thanks to the .NET community for their continuous support and contributions.

