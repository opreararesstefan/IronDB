# Test 1:
- Design the database (create tables, indexes, primary keys, foreign keys) for two tables
o USERS
 Will contain a list of users
 Will have a username and a password field.
o Roles
 Will contain the list of roles for the users
o Create a foreign key between the two
o Create sql statements to insert data into the two tables (two users, three roles) of your choosing
- Create a C# Windows forms application for a login function
o The form will have a username and a password field, plus a login button
o When clicking on the login button will verify in the database the match with the data in the USERS
table
o Will return on a message box success or fail, if the login was successful or not
You must use object oriented design and programming (create classes for USER / ROLE)
               The classes must have CRUD methods (Create, Read, Update, Delete) methods, and other methods as you
see fit (for example the USER class may need a Login method). Also you can use store procedures for queries(not
mandatory but desirable)
It is recommended to use an n-tier architecture
               -DAL (Data Access Layer) for database connectivity
               - BLL (Business Access Layer) that uses DAL classes for CRUD operations but it does not connect directly to
the database
- the app.config will contain any configuration parameters (such as sqlConnection strings and such)
What you need to provide is sql scripts to create the database structure and insert any data into it (Microsoft SQL
Server version 2012, you can download and install the Express version from Microsoft, it is free)
And also a visual studio solution (visual studio solution, version 2010 min)
You also have to provide detailed configuration documentation so that I can configure and run the application in my
development environment.
