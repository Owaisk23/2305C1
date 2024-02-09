CREATE DATABASE school;

use school;

create table teacher (
	teacher_id INT,
    teacher_fname VARCHAR(25),
    teacher_lname VARCHAR(25),
    teacher_hourlypay DECIMAL(5,2),
    teacher_dob DATE
);

SELECT * FROM teacher;

RENAME TABLE faculty TO teacher;


ALTER TABLE teacher 
ADD phone_number varchar(15);


-- ALTER TABLE teacher 
-- rename column email To phone_number;

ALTER TABLE teacher
MODIFY column phone_number varchar(100);


SELECT * FROM teacher;


ALTER TABLE teacher 
MODIFY phone_number varchar(100) 
AFTER teacher_lname;


ALTER TABLE teacher
DROP COLUMN phone_number;


INSERT INTO teacher 
VALUES (1 , "Owais", "Khan", 10.2, "2000-11-23");


INSERT INTO teacher 
VALUES (2 , "Ashar", "Khan", 12.2, "2000-11-22"),
	(3 , "Jahangir", "Khan", 14.2, "2000-11-21"),
    (4 , "Ebad", "Khan", 9.7, "2000-11-20"),
    (5 , "Taha", "Khan", 14.2, "2000-11-19"),
    (6 , "Ali", "Khan", 8.5, "2000-11-18"),
    (7 , "Hamza", "Khan", 7.2, "2000-11-17");


SELECT * FROM teacher 
where teacher_id = 5;

Select * from teacher
where teacher_hourlypay >= 10;

SELECT * FROM teacher
where teacher_dob >= "2000-11-20";


INSERT into teacher (teacher_id, teacher_fname, teacher_lname)
values (8, "Haseeb", "Shahid");

select * from teacher
where teacher_hourlypay IS NULL;

select * from teacher
where teacher_dob IS NOT NULL;

use school;
select * from teacher;

-- update 
UPDATE teacher
SET teacher_hourlypay = 15.24,
	teacher_dob = "2000-5-21"
WHERE teacher_id = 8;

select * from teacher;



UPDATE teacher
SET teacher_hourlypay = 12.23;

select * from teacher;

DELETE FROM teacher
where teacher_id = 8; 

SET AUTOCOMMIT = ON;

DELETE FROM teacher;

ROLLBACK;



