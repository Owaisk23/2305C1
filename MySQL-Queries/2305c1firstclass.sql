-- create database mydb;

-- alter database mydb READ ONLY = 0;

-- drop database mydb;


-- create database 2305c1; 

-- alter database 2305c1 READ ONLY = 0;

-- drop database 2305c1;

create database ecommerce;

use ecommerce;

create table employee (
	emp_id INT,
    emp_fname VARCHAR(25),
    emp_lname VARCHAR(25),
    emp_hourlypay DECIMAL(5,2),
    emp_dob DATE
);

RENAME TABLE workers TO employee;



ALTER TABLE employee
ADD phone_number varchar(15);

ALTER TABLE employee 
RENAME column phone_number To email;

ALTER TABLE employee
MODIFY column email varchar(100);

ALTER TABLE employee
MODIFY email varchar(100)
AFTER emp_lname;

SELECT * FROM employee;

ALTER TABLE employee
DROP COLUMN email;

INSERT INTO employee 
VALUES (1 , "Owais", "Khan", 99.2, "2002-11-23");

SELECT * FROM employee;

INSERT INTO employee 
VALUES (2 , "Ali", "Khan", 99.2, "2000-01-10"),
		(3 , "Haseeb", "Khan", 99.2, "2004-11-13"),
		(4 , "Taha", "Khan", 99.2, "2002-01-03"),
		(5 , "Hamza", "Khan", 99.2, "2003-03-15"),
		(6 , "Ebad", "Khan", 99.2, "2001-09-11");


INSERT INTO employee (emp_id, emp_fname, emp_lname)
VALUES (7, "Abdullah", "Kashif");

select * from employee;











