
CREATE DATABASE ProductCatalog;
GO
USE ProductCatalog;
GO

CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX) NULL,
    Price DECIMAL(10,2) NOT NULL,
    Category NVARCHAR(100) NULL,
    ImageUrl NVARCHAR(500) NULL,
    StockQuantity INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedDate DATETIME NOT NULL
);

INSERT INTO Products (Name, Description, Price, Category, ImageUrl, StockQuantity, CreatedDate, LastUpdatedDate)
VALUES
('Wireless Headphones', 'Bluetooth headphones with noise cancellation', 99.99, 'Electronics', 'https://picsum.photos/seed/headphones/300/200', 25, GETDATE(), GETDATE()),
('Smartphone X1', '6.5" Display, 128GB storage', 399.00, 'Electronics', 'https://picsum.photos/seed/phone/300/200', 12, GETDATE(), GETDATE()),
('Men''s Hoodie', 'Comfort fit, cotton blend', 29.50, 'Clothing', 'https://picsum.photos/seed/hoodie/300/200', 40, GETDATE(), GETDATE()),
('Women''s Sneakers', 'Lightweight running shoes', 59.99, 'Clothing', 'https://picsum.photos/seed/sneakers/300/200', 30, GETDATE(), GETDATE()),
('Modern Lamp', 'LED table lamp with dimmer', 24.99, 'Home', 'https://picsum.photos/seed/lamp/300/200', 18, GETDATE(), GETDATE()),
('Coffee Maker', 'Drip coffee machine 12-cup', 49.00, 'Home', 'https://picsum.photos/seed/coffee/300/200', 10, GETDATE(), GETDATE()),
('C# Programming Book', 'Beginner to advanced topics', 34.95, 'Books', 'https://picsum.photos/seed/book1/300/200', 50, GETDATE(), GETDATE()),
('Cooking Recipes', '100 international recipes', 19.99, 'Books', 'https://picsum.photos/seed/book2/300/200', 60, GETDATE(), GETDATE()),
('Gaming Mouse', 'High-DPI ergonomic mouse', 39.99, 'Electronics', 'https://picsum.photos/seed/mouse/300/200', 20, GETDATE(), GETDATE()),
('Yoga Mat', 'Non-slip 6mm mat', 15.00, 'Sports', 'https://picsum.photos/seed/yogamat/300/200', 35, GETDATE(), GETDATE()),
('Water Bottle', 'Stainless steel 750ml', 12.00, 'Home', 'https://picsum.photos/seed/bottle/300/200', 100, GETDATE(), GETDATE()),
('Kids Puzzle', '200 pieces educational puzzle', 9.99, 'Toys', 'https://picsum.photos/seed/puzzle/300/200', 80, GETDATE(), GETDATE());
GO
