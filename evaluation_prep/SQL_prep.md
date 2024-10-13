Here’s a comprehensive breakdown of the SQL topics you're asking about:

### 1. **What is an Index? Types of Indices; Pros and Cons**
   - **Index**: A database structure that improves the speed of data retrieval at the cost of slower write operations.
   - **Types**:
     - **Clustered Index**: Physically rearranges the table data to match the index.
     - **Non-clustered Index**: Maintains a logical order and pointers to data, but doesn't rearrange the table itself.
     - **Unique Index**: Ensures that all values in the indexed column are unique.
   - **Pros**: Improves query performance, especially for SELECT statements.
   - **Cons**: Slows down write operations (INSERT/UPDATE/DELETE) and takes up additional storage.

### 2. **Primary Key vs. Unique Constraint**
   - **Primary Key**: Ensures uniqueness and automatically adds a NOT NULL constraint.
   - **Unique Constraint**: Ensures uniqueness but allows NULL values (although each NULL must be unique).
   - **Difference**: A table can have only one primary key but multiple unique constraints.

### 3. **CHECK Constraint**
   - Ensures that all values in a column satisfy a specific condition (e.g., `CHECK (age >= 18)`).
   - Used to enforce business rules at the database level.

### 4. **Temp Table vs. Table Variable**
   - **Temp Table**: Stored in the tempdb database and can have indexes. Scope can span beyond a single batch.
   - **Table Variable**: Stored in memory, limited scope within a single batch or procedure, less effective for large datasets.
   - **Difference**: Temp tables allow indexing and can persist across different batches, while table variables are faster for smaller datasets but lack flexibility.

### 5. **WHERE vs. HAVING**
   - **WHERE**: Filters rows before grouping.
   - **HAVING**: Filters groups after the `GROUP BY` clause is applied.

### 6. **RANK() vs. DenseRank()**
   - **RANK()**: Assigns ranks with gaps between ranks when there are ties.
   - **DENSE_RANK()**: Assigns ranks without gaps for ties.
   - **Value Gap**: RANK creates gaps, while DenseRank does not.

### 7. **COUNT(*) vs. COUNT(colName)**
   - **COUNT(*)**: Counts all rows, including NULLs.
   - **COUNT(colName)**: Counts only non-NULL values in the specified column.

### 8. **Left Join vs. Inner Join; JOIN vs. Subquery Performance**
   - **Left Join**: Returns all rows from the left table, and matching rows from the right table.
   - **Inner Join**: Returns only rows that have matching values in both tables.
   - **JOIN vs. Subquery**: Generally, JOINs are faster as they are processed more efficiently by the query optimizer, while subqueries can lead to additional overhead.

### 9. **Correlated Subquery**
   - A subquery that refers to a column in the outer query. It is executed once for each row processed by the outer query.

### 10. **CTE (Common Table Expression)**
   - A temporary result set that you can reference within a SELECT, INSERT, UPDATE, or DELETE statement.
   - **Why use CTE**: Improves readability, makes complex queries more manageable, and is useful for recursion.

### 11. **SQL Profiler**
   - A tool used to monitor and analyze SQL Server activities, such as queries, stored procedures, and performance bottlenecks.

### 12. **SQL Injection**
   - An attack technique where an attacker manipulates a SQL query by injecting malicious code.
   - **Prevention**: Use parameterized queries, stored procedures, and input validation.

### 13. **Stored Procedure (SP) vs. User-Defined Function (UDF)**
   - **SP**: Can return multiple result sets, execute DML/DDL statements, and doesn’t have to return a value.
   - **UDF**: Must return a value, cannot perform transactions or call DDL.
   - **When to use**: Use SP for operations involving multiple actions. Use UDF for computations or returning scalar values.

### 14. **UNION vs. UNION ALL**
   - **UNION**: Combines the result sets of two queries and removes duplicates.
   - **UNION ALL**: Combines the result sets without removing duplicates.

### 15. **Steps to Improve SQL Queries**
   - Use indexing, avoid SELECT *, use proper JOIN types, optimize where clauses, reduce complex subqueries, use CTEs or window functions where applicable.

### 16. **Concurrency Problem in Transactions**
   - Issues like lost updates, dirty reads, and phantom reads can arise when multiple transactions occur simultaneously.

### 17. **What is a Deadlock? How to Prevent?**
   - **Deadlock**: Occurs when two transactions hold locks that the other needs.
   - **Prevention**: Use proper transaction isolation levels, implement timeout policies, and acquire locks in a consistent order.

### 18. **Normalization; 1NF**
   - **Normalization**: Organizing data to reduce redundancy and improve data integrity.
   - **1NF**: Each table cell should contain a single value, and each record must be unique.

### 19. **System Defined Databases**
   - **Examples**: `master`, `tempdb`, `model`, `msdb` (for SQL Server).

### 20. **Composite Key**
   - A primary key made up of more than one column to uniquely identify a record.

### 21. **Candidate Key**
   - A column or set of columns that could be a primary key but is not currently used as one.

### 22. **DDL vs. DML**
   - **DDL (Data Definition Language)**: Deals with schema definitions (e.g., CREATE, ALTER).
   - **DML (Data Manipulation Language)**: Deals with data manipulation (e.g., SELECT, INSERT).

### 23. **ACID Properties**
   - **Atomicity**: All operations succeed or fail together.
   - **Consistency**: Ensures that the database moves from one valid state to another.
   - **Isolation**: Concurrent transactions don’t interfere with each other.
   - **Durability**: Once a transaction is committed, changes are permanent.

### 24. **Table Scan vs. Index Scan**
   - **Table Scan**: Scans the entire table row by row.
   - **Index Scan**: Scans only the index, much faster for large datasets if the index is optimized.

### 25. **Difference between UNION and JOIN**
   - **UNION**: Combines results from two queries.
   - **JOIN**: Combines rows based on a related column between the two tables.

### 26. **One-One, One-Many, Many-Many Relationships**
   - **One-One**: One record in a table is related to one record in another.
   - **One-Many**: One record in a table can relate to many records in another.
   - **Many-Many**: Requires a junction table to handle multiple relationships between two tables.