CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products VALUES
(1,'Laptop A','Electronics',1000),
(2,'Laptop B','Electronics',1200),
(3,'Laptop C','Electronics',1200),
(4,'Chair A','Furniture',200),
(5,'Chair B','Furniture',250),
(6,'Chair C','Furniture',250);

SELECT
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNum,
    RANK() OVER (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNum,
    DENSE_RANK() OVER (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRankNum
FROM Products;
