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


-- update 
UPDATE teacher
SET teacher_hourlypay = 15.24,
	teacher_dob = "2000-5-21"
WHERE teacher_id = 8;

select * from teacher;