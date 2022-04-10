CREATE TABLE [dbo].[Admins] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [Surname]       NVARCHAR (50) NOT NULL,
    [StudentNumber] INT           NOT NULL,
    [DOB]           NVARCHAR (50) NOT NULL,
    [Gender]        NVARCHAR (50) NOT NULL,
    [Age]           INT           NOT NULL,
    [EmailAddress]  NVARCHAR (50) NOT NULL,
    [Password]      NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentNumber])
);

