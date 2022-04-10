CREATE PROCEDURE AdminLogin
(
   @EmailAddress  NVARCHAR (50) NULL,
   @Password      NVARCHAR (50) NULL
)
AS
    BEGIN
         SELECT [dbo].[Admins] (EmailAddress,Password)
    END