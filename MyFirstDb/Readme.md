# MyFirstDb Project

This project demonstrates a basic **ASP.NET Core MVC** application using **Entity Framework Core** for database operations. The project includes the ability to add `Movies` and `Games` to the database.

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- C#

## Project Structure

The project contains the following key components:

### 1. **Entities:**
   - `GameEntity`: Represents a game with properties such as `Name`, `Platform`, and `Rating`.
   - `MovieEntity`: Represents a movie with properties such as `Title`, `Genre`, and `ReleaseYear`.

### 2. **DbContext:**
   - `PatikaFirstDbContext`: Manages database connections and entity sets for `Games` and `Movies`.

### 3. **Controllers:**
   - `TestController`: Contains an `Add()` action to insert a new game and movie into the database.

## Database Configuration

### **Windows Authentication:**

```csharp
optionsBuilder.UseSqlServer(@"Server=DESKTOP-BR8RA9E\SQLEXPRESS; database=PatikaCodeFirstDb1; TrustServerCertificate=true; trusted_connection=true;");
