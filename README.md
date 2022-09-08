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

Step 1: You need version VS.2019 or ++

Step 2: EntityFramework -Version 6.4.4

example: ==>    install nuget ==> https://www.nuget.org/packages/EntityFramework

				pm> Install-Package EntityFramework -Version 6.4.4

Step 3: Set your connctionstring in 
				HotelReception.DataStorage layer / App.config file
				
Note: Set 1-Server Address  2-User  3-Pass
				
example: ==>    <add name="HotelReception" connectionString="Data Source=DESKTOP-FMGH8KG;Initial Catalog=HotelReception;Persist Security Info=True;User ID=sa;Password=1qaz@WSX;MultipleActiveResultSets=True" providerName="System.Data.SqlClient" />

Step 4: Write Update-database in Package Maneger Console

**Note** ==> set DataStorage layer as startup first


Your feedback is valuable!
**Thank you for reading this guide**