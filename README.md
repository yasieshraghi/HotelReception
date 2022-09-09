# HotelReseprion
A Sample Project for Job Interview

Welcome to my Project

## Quickstart

Here's how to get started in a few easy steps.

### Clone this repo

Using your preferred tools, clone the repository. The `git` commmand looks like this:

```bash
git clone https://github.com/yasieshraghi/HotelReception.git
```

### Initialize the project

Step 1: You need version VS.2019 plus

Step 2: EntityFramework -Version 6.4.4
If not install nuget automaticly == >>>
example: ==>    install nuget ==> https://www.nuget.org/packages/EntityFramework

				pm> Install-Package EntityFramework -Version 6.4.4

Step 3: config your connctionstring in 
				HotelReception.DataStorage and HotelReception.App  =>> lib / App.config file
				
Note for config connectionString : Set =>>> your Server Address / your User ID /  your Password
				
example: ==>    <add name="HotelReception" connectionString="Data Source=  your Server Address  ;Initial Catalog=HotelReception;Persist Security Info=True;User ID= your User ID ;Password=   your Password ;MultipleActiveResultSets=True" providerName="System.Data.SqlClient" />

If the database is not created== >>>
Step 4: Write Update-database in Package Maneger Console

**Note** ==> set DataStorage layer ==> Set as startup 


Your feedback is valuable!
**Thank you for reading this guide**