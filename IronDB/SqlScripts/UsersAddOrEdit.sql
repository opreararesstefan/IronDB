CREATE PROCEDURE UsersAddOrEdit
@ID int,
@Username text,
@Passwort text
AS 
if @ID = 0
INSERT INTO dbo.Users(Username, Passwort)
VALUES (@Username, @Passwort)
ELSE
UPDATE Users
SET
Username = @Username,
Passwort = @Passwort
WHERE ID = @ID