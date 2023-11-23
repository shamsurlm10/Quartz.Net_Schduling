# Quartz.Net_Schduling

1. Technology Stack:
ASP.NET Core: A cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications.
Entity Framework Core: An Object-Relational Mapping (ORM) framework for .NET Core.
Quartz.NET: A job scheduling library for .NET applications.


2. Functionality:

The project involves the management of robots, likely stored in a database.
Quartz is used to schedule tasks, such as updating the MadeDate of robots with a specific year every 30 seconds.
Logging is implemented, with log entries recorded in a log table.


3. Project Components:

QuartzService: A service implementing the IJob interface to be used with Quartz for scheduling tasks.
RobotRepository and LogRepository: Repositories for interacting with the database, possibly for retrieving robots and logging entries.
Robot and LogEntry classes: Entity classes representing robots and log entries.
ValuesController: An API controller with an endpoint (Check) that triggers a Quartz job.
