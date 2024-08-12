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
UPDATE Employees Set empName='Taha', city='KHI' where id=2;
UPDATE Employees SET salary=300000 where city='KHI';

--DELETE
DELETE FROM Employees where empName = 'ASHFAQ';

--Where Clause

Select empName, designation from Employees where designation = 'SENIOR FACULTY MEMBER';

-- Not Operator
Select empName, designation from Employees where not designation = 'SENIOR FACULTY MEMBER';

-- And Operator
Select empName, designation, salary from Employees where not
designation = 'SENIOR FACULTY MEMBER' and salary >= 200000;

Select empName, designation, salary from Employees where not
designation = 'SENIOR FACULTY MEMBER' and salary > 20000;

-- OR Operator
Select empName, designation, salary from Employees where not
designation = 'SENIOR FACULTY MEMBER' or salary >= 200000;

Select empName, designation, salary from Employees where not
designation = 'SENIOR FACULTY MEMBER' or salary > 20000;

-- Between
Select * from Employees where id between 2 AND 4;

-- IN

Select * From Employees where city IN ('KHI', 'LHR');

--LIKE

SELECT * FROM Employees where designation like '%a%';

SELECT * FROM Employees where city like '%k%' and designation like '%f%';

-- ORDER BY

SELECT * FROM Employees Order By empName asc;

SELECT * FROM Employees Order By id desc;

-- TOP
SELECT top 4 * FROM Employees;

SELECT top 50 percent * FROM Employees Order By id desc;
