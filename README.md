# ContactApplication
Sample Contact application using Asp.net Core 6.1 web application using Localdb

****Sample Database Script:
1. To create local database using Visual studio 2022, please refer the link https://docs.microsoft.com/en-us/visualstudio/data-tools/create-a-sql-database-by-using-a-designer?view=vs-2022
2. Create one database with name "Sampledb" and run the below "create table" scripts.

USE [Sampledb]
GO

/****** Object: Table [dbo].[Users] Script Date: 13/03/2022 8:33:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    [Secret]   NVARCHAR (50) NOT NULL
);

USE [Sampledb]
GO

/****** Object: Table [dbo].[Contacts] Script Date: 13/03/2022 8:33:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contacts] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    [PhoneNo] NVARCHAR (50) NOT NULL,
    [Email]   NVARCHAR (50) NOT NULL
);

Also used Ntoast Notifications nugget to show notifications to user.

**Screenshots of application**
![image](https://user-images.githubusercontent.com/35318669/158038392-e58c2a73-d540-4b09-a085-b3a002799b49.png)
![image](https://user-images.githubusercontent.com/35318669/158038402-f56d6c46-e35f-4b27-82ab-e1fa1a78237d.png)
![image](https://user-images.githubusercontent.com/35318669/158038413-1f3cfce9-e4ff-4ed7-b4c8-785239f107dd.png)
![image](https://user-images.githubusercontent.com/35318669/158038478-5e3a605e-b6e4-429a-94da-80b9ae325f62.png)
![image](https://user-images.githubusercontent.com/35318669/158038463-8322a293-67f7-490c-baf9-9798f81ff44e.png)
![image](https://user-images.githubusercontent.com/35318669/158038490-c34234f1-17b4-4b91-9d81-0e7636988cf8.png)


**Note:** Visual Studio 2022 is required to open the project.


