Before you start:

1. You can change the connection string to what DB Server you have currently installed on you machine. If you have SQL Server Express, that should just work.
2. Run the update database command so the solution can create the DB and prepopulate it. In package manager console, "update-database" or "dotnet ef database update -p GLTest.Core -s GLTest". If you are using PostgreSQL, you might have to update the migration sql script. The file is under the Migrations folder named 20240703015430_SeedData.cs.
3. Clone this repo and make your changes there. You can just send us the link to the repo once done.

Objective:
The objective of this test is to see how easily you can adapt to an already existing code base and to test your DB migration skills. 
The application consists of two tables in the database - Product and Category. Currently, Product only supports one Category. We want to change this so that we can set multiple categories to a product. 
Existing data should still persist after the model change.

Note:
This is a slim version of the codebase that this role will have to work with. 
# GLTest
