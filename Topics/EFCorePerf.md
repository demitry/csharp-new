
## 16 Steps Guide To Improve EF Core Performance

- Use projections
- Use Async Methods
- Use compiled queries in EF
- Avoid non cancellable queries
- Include only necessary tables
- Select desired rows ( obviously)
- For bulk processing use chunks
- Use Any method of LINQ for filters
- Use DbContextPool with DB contexts
- For multiple filters use IQueryable
- Don't use raw SQL queries everywhere
- Use AsNoTracking for readonly operations
- Use Pagination, don't bring all data once
- Use TryGetNonEnuneratedCount for Count
- Avoid using SQL Queries in for each loop.
- Reduce round trips to db by calling SaveChangesAsync one time for bulk operations