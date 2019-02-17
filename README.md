# Coding challenge
Coding challenge project is a implementation of a Project Managenment Website

# Tools
	-  Visual Studio 2017
	-  Sql server 2014 or later version

# Project Solution
## WebAPI - It manage the data access and backend logic
	- Implemented using code first approach and dependency injection with autofac
	
## SPA  - It manage the frontend logic and html design.
	- Implemented with JQuery and boostrap using the last versions. 

# How to run the project
	- Download the project from Github
	- Open the project from Visual Studio 2017
	- Restore Nuget packages. 
	- Check connection string definition into Web.config file
	- Run Migrations scripts to create the initial DB. Follow these steps:
		- Open Package Manage Console from VS 2017.
		- Run the command: **Update-Database**
	- Check database, tables and data were created in SQL Server.
	- Right click on CodingChallenge.WebApi project
		- Select Debug -> Start new instance
	- Right click on CodingChallenge.SPA project
		- Select Debug -> Start new instance

		
