CREATE PROCEDURE InsertEmployer(

@employerName NVARCHAR(100),
@employerID INT,
@address NVARCHAR(500)
)
AS
BEGIN
INSERT INTO EmployerDetail
(EmployerName, EmployerID, [Address])
VALUES
(@employerName, @employerID, @address)
END