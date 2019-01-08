USE [RestUdemy]
GO

/****** Object: Table [dbo].[persons] Script Date: 07/01/2019 13:12:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[persons];


GO
CREATE TABLE [dbo].[persons] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50) NULL,
    [LastName]  NVARCHAR (50) NULL,
    [Address]   NVARCHAR (50) NULL,
    [Gender]    NVARCHAR (50) NULL
);


