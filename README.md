# AccountOwnerServer - REST API with ASP.NET Core
This repository contains a controller which deals with Account-Owner database. You can GET/POST/PUT/DELETE them.

## Prerequisites
Download [Visual Studio](https://visualstudio.microsoft.com/vs/),
[MYSQL](https://dev.mysql.com/downloads/mysql/) 
[(Setup MYSQL)](https://dev.mysql.com/doc/mysql-getting-started/en/#mysql-getting-started-installing), 
[Sample database](https://github.com/inochoi/AccountOwnerServer/tree/master/Sample%20Database) -
if you haven't on your system.

## Installation
1. Use accountowner.sql to create MySQL database.
2. Use accountowner-init.sql to populate database.
3. Build the solution using Visual Studio.
4. In AccountOwnerServer/AccountOwnerServer/appsettings.json, set the connection string to your database.<br />
(**NOTE:** Make sure these file paths are correct for your application.)
5. In AccountOwnerServer/AccountOwnerServer/nlog.config, set internalLogFile and fileName to your own file paths.<br />
(**NOTE:** Make sure these file paths are correct for your application.)
6. Run the project. The API will start up on http://localhost:5000

## API Overview

| HTTP Type | API URL                          | Comments                                               |
|-----------|----------------------------------|--------------------------------------------------------- 
| GET       | /api/owner                       | Gets all owners table                                  |
| GET       | /api/account                     | Gets all accounts table                                |
| GET       | /api/owner/:id                   | Retrieves data by owner id                             |
| GET       | /api/account/:id                 | Retrieves data by account id                           |
| GET       | /api/owner/:id/account           | Retrieves data by owner id with accounts associated to the owner |
| GET       | /api/account/:id/owner           | Retrieves data by account id with owner associated to the account |
| POST      | /api/owner                       | Create a new owner                                     |
| POST      | /api/account                     | Create a new account                                   |
| PUT       | /api/owner/:id                   | Replace existing owner information with new one        |
| PUT       | /api/account/:id                 | Replace existing account information with new one      |
| DELETE    | /api/owner/:id                   | Deletes owner by id                                    |
| DELETE    | /api/account/:id                 | Deletes account by id                                  |
|-----------|----------------------------------|--------------------------------------------------------- 

The front-end application is in my **[`AccountOwnerClient`](https://github.com/inochoi/AccountOwnerClient)** repository.