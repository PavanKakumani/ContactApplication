# ContactApplication
Sample Contact application using Asp.net Core 6.1 web application using Localdb

Sample Database Script:
1. Create one database with name "Sampledb" and run the below "create table" scripts.

USE [Sampledb]
GO

/****** Object: Table [dbo].[Users] Script Date: 13/03/2022 8:33:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Email]    NCHAR (10)    NOT NULL,
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


**Note:** Visual Studio 2022 is required to open the project.


