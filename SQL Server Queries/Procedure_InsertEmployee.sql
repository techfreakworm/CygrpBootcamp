CREATE PROCEDURE InsertEmployee(

@employeeName VARCHAR(100),
@employeeID VARCHAR(150),
@designation VARCHAR(50),
@doj DATE,
@salary DECIMAL(18,0),
@contactNumber NCHAR(20),
@employerID INT
)
AS
BEGIN
INSERT INTO EmployeeDetail
(EmployeeName, EmployeeID, Designation, DOJ, Salary, ContactNumber, EmployerID)
VALUES
(@employeeName, @employeeID, @designation, @doj, @salary, @contactNumber, @employerID)
END