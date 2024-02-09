use tts9_11;

select * from students;
call get_student_by_age(22);

call id_range(1,4);
call get_student_by_age(@record,22);
select @record as total;

-- insert_val(1,"haris",24,"male",90);
call addrec(7,"Uzzam",24,"multan","Uzzam@gmail.com","male");

call remove(4);


select ABS(-5.89);
select ceil(3.98);
select ceil(3.1);
select floor(3.1);
select floor(3.9);
select SIN(90);
select COS(90);
select sqrt(625);
select ascii("a");
select char_length("hello");
select concat("hello", " world ");

select curdate();
select curtime();
select current_timestamp();
