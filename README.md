# AccountServerAPI

## Prerequisites
Download [Visual Studio](https://visualstudio.microsoft.com/vs/),
[MYSQL](https://dev.mysql.com/downloads/mysql/) 
[(Setup MYSQL)](https://dev.mysql.com/doc/mysql-getting-started/en/#mysql-getting-started-installing), 
[Sample database](https://github.com/inochoi/AccountOwnerServer/tree/master/Sample%20Database) -
if you haven't on your system.

## Installation
1. Use accountowner.sql to create MySQL database.
2. Use accountowner-init.sql to populate database.
3. Open project with Visual Studio.
4. In AccountOwnerServer/AccountOwnerServer/appsettings.json, set the connection string to your database.
(**NOTE:** Make sure these file paths are correct for your application.)
5. In AccountOwnerServer/AccountOwnerServer/nlog.config, set internalLogFile and fileName to your own file paths.
(**NOTE:** Make sure these file paths are correct for your application.)
6. Run server.

The front-end application is in my **[`AccountOwnerClient`](https://github.com/inochoi/AccountOwnerClient)** repository.
