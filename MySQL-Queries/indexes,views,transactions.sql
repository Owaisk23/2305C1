-- indexes
use tts9_11;
show indexes from payment;
create index amount_idx on payment(amount);
alter table payment drop index amount_idx;
-- views
create view student_email as
select STUDENT_NAME, EMAIL from students;
select * from student_email;
select * from students;

update students
set city="karachi",
email="asher@gmail.com"
where id=2;

delete from students
where id =1;

-- transactions
delete from students
where age<200;

rollback;

delete from students
where age<20;
commit;
-- start point


