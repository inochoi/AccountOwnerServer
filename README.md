# AccountServerAPI

## Prerequisites
Download [mysql](https://dev.mysql.com/downloads/mysql/) 
[(setup mysql)](https://dev.mysql.com/doc/mysql-getting-started/en/#mysql-getting-started-installing), 
[sample database](https://dev.mysql.com/doc/employee/en/employees-installation.html),
[database init]() -
if you haven't on your system.

## Installation
1. Use accountowner.sql to create MySQL database.
2. Use accountowner-init.sql to populate database.
3. In AccountOwnerServer/AccountOwnerServer/appsettings.json, set the connection string to your database. (**STUDENTS:** Make sure these file paths are correct for your application. Remove your password from this file before uploading)
4. In AccountOwnerServer/AccountOwnerServer/nlog.config, set internalLogFile and fileName to your own file paths. (**STUDENTS:** Make sure these file paths are correct for your application. Remove your file paths from this file before uploading)
5. Run server.

The front-end application is in my **[`AccountOwnerClient`](https://github.com/inochoi/AccountOwnerClient)** repository.
