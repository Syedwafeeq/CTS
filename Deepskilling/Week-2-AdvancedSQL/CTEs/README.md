# Common Table Expressions (CTEs)

A Common Table Expression (CTE) is a temporary named result set that exists only during the execution of a query.

## Advantages

* Improves query readability
* Simplifies complex SQL
* Supports recursive queries
* Easier maintenance

## Syntax

WITH CTE_Name AS
(
SELECT Columns
FROM TableName
)
SELECT *
FROM CTE_Name;

## Example

The `HighSalaryEmployees` CTE filters employees whose salary exceeds 55,000.
