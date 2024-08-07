CREATE DATABASE "2305C1";
-- Create
CREATE TABLE Employees(
	id INT PRIMARY KEY IDENTITY(1,1),
	empName VARCHAR(255) NOT NULL,
	designation VARCHAR(255) NOT NULL,
	salary INT NOT NULL,
	city VARCHAR(255) NOT NULL,
	deptId INT
);
--Insert
INSERT INTO Employees(empName, designation, salary, city, deptId) VALUES
('WAJEEHA', 'HEAD COORDINATOR PAKISTAN', 900000, 'BahriaTown KHI', null),
('ASMA', 'DCAH', 1900000, 'DHA KHI', null),
('ASHFAQ', 'CAH', 2900000, 'KHI', null),
('OWAIS', 'SENIOR FACULTY MEMBER', 30000, 'KHI', null),
('AFFAN', 'MANAGER', 200000, 'LHR', null),
('SHIFA', 'ACADMIC COORDINATOR', 80000, 'ISB', null);
--read
SELECT * FROM Employees;

SELECT DISTINCT city from Employees;
--Update
UPDATE Employees Set empName='Taha', city='Multan' where id=2;
UPDATE Employees SET salary=300000 where city='KHI';

--DELETE
DELETE FROM Employees where empName = 'ASHFAQ';
