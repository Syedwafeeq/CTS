# SQL Server Cursors

## What is a Cursor?

A cursor is a database object used to process query results row by row.

Unlike normal SQL operations that work on entire result sets, cursors allow individual row processing.

## Cursor

1. Declare Cursor
2. Open Cursor
3. Fetch Rows
4. Process Data
5. Close Cursor
6. Deallocate Cursor

## Basic Syntax

```sql
DECLARE cursor_name CURSOR FOR
SELECT column_name
FROM table_name;
```

## Advantages

* Row-by-row processing
* Useful for complex business logic
* Suitable when set-based operations are difficult

## Disadvantages

* Slower than set-based queries
* Consumes more memory and resources
* Not recommended for large datasets

## Alternatives

Whenever possible use:

* JOINs
* CTEs
* Window Functions
* Aggregate Functions

## Conclusion

Cursors should be used only when row-by-row processing is required and no efficient set-based solution exists.
