# Hexagonal Architecture
### [Readme in Portuguese](https://github.com/GabrielAm0/Hexagonal-Architecture/blob/main/readme.md)


![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![PostgreeSQL](https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)

This project is an API built using **C#, .NET CORE, Entity Framework, PostgreSql.**

The microservice was developed to demonstrate how to implement the Hexagonal Architecture pattern in a .NET Core
application. The project is a simple API that manage products in a store.

## Contents

- [Hexagonal Architecture](#hexagonal-architecture)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)

## Hexagonal Architecture

The Hexagonal Architecture is a software architecture pattern that allows the creation of loosely coupled application
components. This pattern is also known as Ports and Adapters, and it is based on the idea of dividing the application
into layers, with each layer having a specific responsibility.

The Hexagonal Architecture pattern consists of three main layers:

1. **Application Layer**: This layer contains the application logic and is responsible for coordinating the interaction
   between the other layers. It receives input from the external world and delegates the processing to the domain layer.

2. **Domain/Core Layer**: This layer contains the core business logic of the application. It defines the entities, value
   objects, and business rules that govern the behavior of the application.

3. **Infrastructure Layer**: This layer contains the implementation details of the application, such as database access,
   external services, and other dependencies. It provides the necessary infrastructure for the application to run.

The Hexagonal Architecture pattern promotes the separation of concerns and makes the application more modular and
testable. It also allows for easy integration of new components and changes to existing components without affecting the
rest of the application.

## Installation

1. Install the .NET SDK in your machine. This project was built using .NET 8:

   [Download .NET SDK 8.0](https://dotnet.microsoft.com/download)


2. Clone the repository:

```bash
git clone https://github.com/GabrielAm0/Hexagonal-Architecture.git
```

3. Install PostgreSql in your machine

   [Download PostgreSql](https://www.postgresql.org/download/)

## Usage

1. Open the project in Rider or Visual Studio
2. Run on CLI the following commands:

```bash
    dotnet ef migrations add ProductsMigration
```

```bash
    dotnet ef database update
```

3. Update `appsettings.json` puting your PostgreSql Connection Strings

```csharp
"ConnectionStrings": {
  "DefaultConnection":"User ID= ;Password= ;Host= ;Port= ;Database= ;Pooling=true;"
}
```

4. Start the application with .NET
5. The API will be accessible at https://localhost:7115/swagger/index.html

## API Endpoints

The API provides the following endpoints:

1. **GET Product by ID**

```http request
GET /api/Products/"{id}" - Get a product by ID
```

2. **GET All Products**

```http request
GET /api/Products - Get all products
```

3. **POST Product**

```http request
GET /api/Products - Get all products
```

**BODY**

```json
{
  "name": "test",
  "price": 10.0
}
```

4. **DELETE Product**

```http request
DELETE /api/Products/"{id}" - Delete product by ID
```

5. **UPDATE Product**

```http request
PUT /api/Products/"{id}" - Delete product by ID
```

**BODY**

```json
{
  "name": "test",
  "price": 10.0
}
```

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a
pull request to the repository.

When contributing to this project, please follow the existing code
style, [commit conventions](https://www.conventionalcommits.org/en/v1.0.0/), and submit your changes in a separate
branch.
