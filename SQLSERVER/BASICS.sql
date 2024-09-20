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

select * from Employees;

-- Aggregate Functions

SELECT COUNT(city) as total_cities from Employees;

SELECT MIN(salary) as minimum_salary from Employees;

SELECT MAX(salary) as maximum_salary from Employees;

SELECT SUM(salary) as total_salary from Employees;

SELECT SUM(id) as total_id from Employees;

SELECT AVG(salary) as avg_salary from Employees;

SELECT CONCAT(empName,' work as a ', designation, ' gets salary of RS ', salary) 
as emp_details from Employees;

SELECT empName, salary from Employees where salary < (SELECT AVG(salary) as avg_salary from Employees);

-- Group By Clause
SELECT city, COUNT(id) workers from Employees Group By city;

SELECT city, MAX(salary) max_salary_paid from Employees Group By city;

SELECT city, SUM(salary) total_salary_paid from Employees Group By city;



INSERT INTO Employees(empName, designation, salary, city, deptId) VALUES
('Ali Asr', 'MANAGER', 420000, 'KHI', null),
('Ebad', 'MANAGER', 670000, 'ISB', null),
('Bilal', 'MANAGER', 220000, 'LHR', null);

Select * FROM Employees;


SELECT designation, COUNT(id) from Employees Group By designation having designation = 'MANAGER';

-- Department Table

CREATE table Departments (
deptId int PRIMARY KEY IDENTITY(1,1),
DName nvarchar(40) not null
);

insert into Departments values ('HR'), ('Academics'), ('Accounts'), ('SRO');

SELECT * FROM Departments;

SELECT * FROM Employees;

TRUNCATE TABLE Employees;

DROP TABLE Employees;


CREATE TABLE Employees(
	id INT PRIMARY KEY IDENTITY(1,1),
	empName VARCHAR(255) NOT NULL,
	designation VARCHAR(255) NOT NULL,
	salary INT NOT NULL,
	city VARCHAR(255) NOT NULL,
	deptId INT,
	FOREIGN KEY (deptId) References Departments(deptId)
);


INSERT INTO Employees(empName, designation, salary, city, deptId) VALUES
('Ali Asr', 'CAH', 420000, 'KHI', 2),
('Ebad', 'Placement Officer', 670000, 'ISB', 1),
('Bilal', 'Fee Collector', 220000, 'LHR', 4),
('Haseeb', 'Coordinator', 670000, 'KHI', 2),
('Taha', 'Admin Accountant', 220000, 'LHR', 3),
('Abdullah', 'Manager', 670000, 'KHI', 2),
('Azhar', 'Faculty', 220000, 'ISB', 2);

SELECT * FROM Employees;

-- JOINS
--INNER JOIN 
SELECT * FROM Employees as emp INNER JOIN Departments as d on emp.deptId=d.deptId;

--LEFT JOIN 
SELECT * FROM Employees as emp LEFT JOIN Departments as d on emp.deptId=d.deptId;

SELECT * FROM Departments as emp LEFT JOIN Employees as d on emp.deptId=d.deptId;

--RIGHT JOIN 
SELECT * FROM Employees as emp RIGHT JOIN Departments as d on emp.deptId=d.deptId;

--FULL OUTER JOIN
SELECT emp.*, d.DName FROM Employees as emp FULL OUTER JOIN Departments as d on emp.deptId=d.deptId;

-- VIEWS 
SELECT * FROM Employees;

CREATE View [empDetails]
AS
SELECT id, empName, designation from Employees;

CREATE View [empDeptName]
AS
SELECT DName FROM Departments;

select * from empDeptName;


Create VIEW [empDetailwithDept]
AS
SELECT emp.*, d.DName from Employees as emp INNER JOIN Departments as d ON emp.deptId = d.deptId;

SELECT * from [empDetailwithDept];

UPDATE Employees SET empName = 'Owais Ahmed' where id = 1;

delete from Employees where id = 7;

-- DATA CONTROL LANGUAGE DCL

CREATE LOGIN EMP_CLERK WITH Password='555';
CREATE USER EMP_CLERK From LOGIN EMP_CLERK;

Select * FROM sys.sql_logins;

-- GRANT TO GIVE PERMISSION

GRANT SELECT, INSERT on dbo.Employees TO EMP_CLERK;

grant DELETE on dbo.Employees TO EMP_CLERK;

-- REVOKE(To take back the permission)

REVOKE DELETE on dbo.Employees TO EMP_CLERK;

-- PROCEDURES

CREATE PROCEDURE SeeEmp
AS
BEGIN
SELECT * FROM Employees
END;

SeeEmp;


ALTER PROCEDURE SeeEmp
AS
BEGIN
SELECT * FROM Employees where city='LHR'
END;

SeeEmp;

CREATE PROCEDURE AddEmp @Name varchar(255), @desig varchar(70), @sal int, @city varchar(60), @dId int
AS
BEGIN
INSERT INTO Employees VALUES(@Name, @desig, @sal, @city, @dId)
SELECT * FROM Employees
END;

AddEmp @Name='Haseeb', @desig='Software Developer', @sal=50000, @city='Karachi', @dId=2;

AddEmp @Name='Yumna', @desig='Flutter Developer', @sal=150000, @city='Lahore', @dId=1;

DROP PROCEDURE SeeEmp;

Select * from e
DELETE FROM Employees where id = 1004;

-- indexes 

create index empname_index
On Employees(empName,salary);

select * from Employees where empName='Owais';

drop index employees.empname_index;

-- Triggers

 -- for
 CREATE TRIGGER AddEmp_trigger 
 On Employees
 for INSERT
 as
 BEGIN
 print('a new employee added successfully.')
 END;

 INSERT INTO Employees(empName,designation,salary,city,deptId) VALUES
('Hussain ','developer',78788, 'jammu',2);


 -- after
 ALTER TRIGGER AddEmp_trigger 
 On Employees
 for INSERT
 as
 BEGIN
SELECT * FROM inserted;
 END;

 --Creating audit table
 CREATE TABLE EmpLogs(
 logid int Primary key identity(1,1),
 ActionPerformed nvarchar(255)
 );
 SELECT * FROM EmpLogs;


 SELECT * into Test from Employees;
 SELECT * From Test;

 -- Maintaining logs on tables

  create TRIGGER AddEmp_trigger 
 On Employees
 AFTER INSERT
 as
 BEGIN
DECLARE @Id int, @name varchar(50)
SELECT @Id=id, @name=empName FROM inserted
INSERT INTO EmpLogs VALUES(@name+' having Id = '+ CAST(@Id as varchar(6)) +' is added at '+ cast(GETDATE() as varchar(30)))
 END;


 -- instead of

 SELECT * from Employees;
 Alter TABLE Employees ADD emp_status int default(1) not null;


 CREATE Trigger Soft_Delete
 On Employees
 INSTEAD OF DELETE
 AS
 BEGIN
 DECLARE @ID int
 SELECT @ID=id from Deleted
 Update Employees set emp_status=0 where id=@ID
 END;


 DELETE from Employees where id=8;


 -- Update Trigger
 ALTER Trigger Update_Employees
 On Employees
 for Update
 as
 begin
DECLARE @Id int
DECLARE @Newname varchar(60), @Oldname varchar(60)
DECLARE @Newsalary int,  @Oldsalary int
DECLARE @NewDesignation varchar(60),@OldDesignation varchar(60)
DECLARE @Newdeptid int,  @Olddeptid int
DECLARE @Newcity varchar(60), @Oldcity varchar(60)
DECLARE @AuditString varchar(255)

SELECT * into #Temptable from inserted
WHILE(exists (SELECT id from #Temptable))
begin
SELECT @Id=id, @Newname=empName, @Newsalary=salary, @NewDesignation=designation,@Newcity=city,@Newdeptid=deptId FROM #Temptable
SELECT  @Oldname=empName, @Oldsalary=salary, @OldDesignation=designation,@Oldcity=city,@Olddeptid=deptId FROM deleted where id=@Id
SET @AuditString =''
SET @AuditString ='An employee having id = '+ CAST(@Id as varchar(6))+' on '+  CAST(GETDATE() as varchar(30))+' is changed '
if(@Oldname <> @Newname)
SET @AuditString = @AuditString + ' its name from '+@Oldname +' to '+ @Newname

if(@Oldsalary <> @Newsalary)
SET @AuditString = @AuditString + ' its salary from '+CAST(@Oldsalary as varchar(10)) +' to '+CAST(@Newsalary as varchar(10))

if(@OldDesignation <> @NewDesignation)
SET @AuditString = @AuditString + ' its designation from '+@OldDesignation +' to '+ @NewDesignation

if(@Oldcity <> @Newcity)
SET @AuditString = @AuditString + ' its city from '+@Oldcity +' to '+ @Newcity

if(@Olddeptid <> @Newdeptid)
SET @AuditString = @AuditString + ' its deptid from '+CAST(@Olddeptid as varchar(10)) +' to '+CAST(@Newdeptid as varchar(10))
 Insert into Emplogs values(@AuditString)
 DELETE FROM #Temptable where id=@Id
end
 end;


 select * from Employees;
 update Employees set city='karachi' where id > 4;
 select * from Emplogs;

 -- Transactions 
 -- ddl- data definition language (create , alter, drop)
 -- dml-data manipulation language (insert,update,delete, select)
 -- dcl-data control languages (grant/revoke)
 -- tcl- transaction control language. (ROLLBACK/ COMMIT)

 -- ACID properties.
 
-- A => Atomicity -- all the steps are fully completed or not a single step will execute.
-- C => Consistency -- all the nodes in a network should be aware of the transaction.
-- I => Isolation -- one transaction's info should not be known to another transaction.
-- D => Durability -- changes after transaction should be saved.

-- Integrity
Begin Transaction
Update Employees set empName='Khurram' where id= 1;
Commit Transaction;-- save changes

Rollback Transaction;-- wapis

BEGIN TRANSACTION
BEGIN try 
Update Employees set empName='chakwal' where id= 1/0;
print('Commited Successfully.')
COMMIT TRANSACTION
End try
BEGIN catch
print('Rolled back Successfully.')
Rollback Transaction
END catch;

