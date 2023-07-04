What is Hangfire , how it can help you in performing background jobs in .NET Core ?
Hang fire is open-source and used to schedule jobs with a simple implementation in .NET Core .
Three simple steps to use it
- Install Hangfire  Nuget Package 
- Add its configuration in Program.cs
- Use it
These are the benefits of using Hangfire
- Simple
- Reliable
- Efficient
- Extensible
- Distributed
-Self maintainable
- Transparent with web interface
- Persistent Storage (SQL Server + Redis)
- Configure database by just passing connection string
Some practical use cases
- Reports 
- Mass emails
- Notifications
Types of jobs
 - Event based
- Fire and forget jobs
- Delayed jobs
- Recurring jobs
- Dependent jobs (When A finish do B)