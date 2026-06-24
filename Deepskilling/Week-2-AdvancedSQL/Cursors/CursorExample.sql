DECLARE @ProductName VARCHAR(100);

DECLARE ProductCursor CURSOR FOR
SELECT ProductName
FROM Products;

OPEN ProductCursor;

FETCH NEXT FROM ProductCursor
INTO @ProductName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @ProductName;

    FETCH NEXT FROM ProductCursor
    INTO @ProductName;
END

CLOSE ProductCursor;

DEALLOCATE ProductCursor;
