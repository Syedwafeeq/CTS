# SQL Server Exception Handling

## Overview

Exception handling allows SQL Server to gracefully handle runtime errors and continue execution safely.

## TRY...CATCH Block

SQL Server provides TRY and CATCH blocks to capture and handle errors.

### Syntax

```sql
BEGIN TRY
    -- SQL Statements
END TRY

BEGIN CATCH
    -- Error Handling
END CATCH
```

## Error Functions

* ERROR_NUMBER()
* ERROR_MESSAGE()
* ERROR_LINE()
* ERROR_PROCEDURE()

## THROW Statement

Used to raise custom exceptions.

```sql
THROW 50001, 'Custom Error Message', 1;
```

## Advantages

* Prevents unexpected failures
* Improves debugging
* Provides meaningful error messages

## Use Cases

* Stored Procedures
* Transactions
* Data Validation
* Business Logic
