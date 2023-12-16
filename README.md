# BlackCoderNewsArticlesExams
Project Overview:

Purpose: A web application for managing articles, exams, and users.

Technology Stack:

Framework: Built on .NET 6.0.
Authentication: Utilizes ASP.NET Identity for user authentication and authorization.
Database: Uses Entity Framework Core to interact with a SQL Server database (ArticlesContext).
API Integration: Integrates with an external news API (newsdata.io) to fetch news articles based on user-specified themes and languages.
Features and Components:

Role Management: Defines roles ("Admin" and "User") and initializes them during application startup.
User Management: Creates default users (e.g., "Admin") during initialization.
Articles and Exams: Manages articles, exercises, tests, and related data (e.g., answers, test results) using the ArticlesContext.
Web Pages: Contains Razor Pages (Articles.Pages) that display fetched news articles based on user search parameters (theme and languages).
Extensions: Provides custom extensions, like shuffling collections and obtaining random indexes for collections.
External APIs:

Interacts with newsdata.io API to retrieve news articles. The API key and URL are stored in the application for integration.
Additional Notes:

The code includes functionalities for displaying news articles based on user-selected themes and languages.
There are forms (likely for search queries) and corresponding HTML/Razor markup to facilitate user interaction.
The project establishes and manages user roles, and it seems to seed default data (tests, exercises, answers) into the database during application startup for testing purposes.
