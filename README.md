 Product Catalog – Angular + .NET Core
 Project Overview

This is a full-stack web application built using Angular 16 (frontend), .NET 8 Web API (backend), and SQL Server (database).
The application displays a catalog of products, allows users to filter by category, search by name/description, and filter by price range, with the ability to view detailed product information.

🚀 Tech Stack

Frontend: Angular 16, Bootstrap 5
Backend: .NET 8 Web API, Entity Framework Core
Database: MS SQL Server
Version Control: Git / GitHub

📂 Project Structure
/ProductCatalogApp
  ├── /backend (ASP.NET Core Web API)
  │     ├── Controllers/
  │     ├── Models/
  │     ├── Data/
  │     └── ProductCatalogApi.csproj
  │
  ├── /frontend (Angular 20 App)
  │     ├── /src
  │     │    ├── /app
  │     │    │    ├── /models
  │     │    │    ├── /services
  │     │    │    ├── /components
  │     │    │    └── app.module.ts
  │     │    └── index.html
  │     └── angular.json
  │
  └── PCreate-seed.sql  (DB script with schema + sample data)


📊 Database

Run the script Products.sql in SQL Server to create and seed the Products table.

Schema:
Id (INT, Primary Key)
Name (NVARCHAR)
Description (NVARCHAR)
Price (DECIMAL)
Category (NVARCHAR)
ImageUrl (NVARCHAR)
StockQuantity (INT)
CreatedDate (DATETIME)
LastUpdatedDate (DATETIME)
