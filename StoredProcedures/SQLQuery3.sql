CREATE PROCEDURE [dbo].AddUser
	@Name          NVARCHAR (50)  NULL,
    @Surname       NVARCHAR (50)  NULL,
    @StudentNumber INT            NULL,
    @DOB           NVARCHAR (50)  NULL,
    @Gender        NVARCHAR (50)  NULL,
    @Age           NVARCHAR (50)  NULL,
    @EmailAddress  NVARCHAR (50)  NULL,
    @Password      NVARCHAR (50)  NULL
AS
	INSERT INTO [dbo].[Admins](Name, Surname, StudentNumber, DOB, Gender, Age, EmailAddress, Password)
	VALUES (@Name, @Surname, @StudentNumber, @DOB, @Gender, @Age, @EmailAddress, @Password)
RETURN 0