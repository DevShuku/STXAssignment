# STXAssignment Solution
Source code is placed at GitHub https://github.com/DevShuku/STXAssignment

It is a source code for designing and implementing a microservice architecture for the given 
requirement as below.
Requirements:
Code Development:
1. Create two APIs for each module: Customer, Supplier, and Meetings.
2. The first API will retrieve the count of records, such as the number of customers.
3. The second API will retrieve a list of records, providing details for each customer.
4. Create an API to display a list of trade transactions based on their IDs

📢 This project is built with **.net 8.0

## Swagger Page
  https://localhost:7053/swagger/v1/swagger.json

## Tech stack 
   - Dotnet core 8.0
 
## Database 
    - MySQL 8.4.0 
   

## Note ⚠️
  - Initially static dataset is used for the all the endpoints. 
  - usefull data creation script is added along  > STXAssignment\Data\usefulscripts.sql
  - A backup file is attached in https://github.com/DevShuku/STXAssignment/tree/master/Data/stxassignmentdbfinal_backup_file.sql
  - Run the abow backup file for restoring the database in local MySQL Database and use the same database name in 'appsettings.json' file connection string. and you are good to go!
   
  ## How to run the project?
On pre installed **Visual Studio 2022** (It is the latest as of May,2024). Now, follow the following steps.
1. Open command prompt. Go to a directory where you want to clone this project. Use this command to clone the project.
   ```
     git clone https://github.com/DevShuku/STXAssignment.git
   ```
2. Go to the directory where you have cloned this project, open the directory `STXAssignment`. You will find a file with name `STXAssignment.sln`. Double click on this file and this project will be opened in Visual Studio.
## Since there is no database connection we can skip this part else the below is a vital step  
3.  open `appsettings.json` file and update connection string in your local and run on the localhost after configuring the MySQL datacontext.
 
   ```
     "ConnectionStrings": {

         "STXSssignmentCon": "Data Source=localhost;Database={Database name};User={username};Password={password};"
       
     }
   ```
4. Now you can run this project

5. Scope of extenstion to this projects are:
   a) Custom Exception handling pages
   b) Unit test implementation.
   c) SonarQube implementation for the code quality purpose 

Thanks a lot 🙂🙂

