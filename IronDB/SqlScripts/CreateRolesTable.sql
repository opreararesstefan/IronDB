CREATE TABLE Roles
(
    RolesId int IDENTITY (1,1) NOT NULL PRIMARY KEY,
    id int NOT NULL REFERENCES Users(id),
    Roles nvarchar(60)
);