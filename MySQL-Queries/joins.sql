-- joins --
use tts9_11;

create table city(
ID INT PRIMARY KEY,
C_NAME VARCHAR(50)  NOT NULL
);
SELECT * FROM city;
INSERT INTO city values
(1,"Karachi"),
(2,"Lahore"),
(3,"Multan"),
(4,"Quetta"),
(5,"Islamabad");

create table STD_DET(
ID INT PRIMARY KEY,
NAME VARCHAR(50)  NOT NULL,
AGE INT NOT NULL,
CITY_ID INT,
FOREIGN KEY (CITY_ID) REFERENCES city(ID) 
);

INSERT INTO STD_DET values
(1,"HARIS",23,1),
(2,"HASSAN",22,2),
(3,"ADNAN",22,1),
(4,"ZEESHAN",25,3),
(5,"WALEED",20, NULL);

SELECT * FROM STD_DET;

-- INNER JOIN
SELECT S.ID,S.NAME ,S.AGE,C.C_NAME FROM STD_DET AS S
INNER JOIN city AS C
ON S.CITY_ID= C.ID;   

-- left JOIN
SELECT S.ID,S.NAME ,S.AGE,C.C_NAME FROM STD_DET AS S
LEFT JOIN city AS C
ON S.CITY_ID= C.ID;       
 
 -- right JOIN
SELECT S.ID,S.NAME ,S.AGE,C.C_NAME FROM STD_DET AS S
RIGHT JOIN city AS C
ON S.CITY_ID= C.ID;   


-- cross join 
select * from std_det as s
cross join city
order by s.id asc;

create table emp(
id int primary key,
name varchar(40),
manager_id int
);
insert into emp values
(1,"Haris",2),
(2,"owais",3),
(3,"Ebad",null),
(4,"afzal",1),
(5,"usama",4),
(6,"moiz",1);

select * from emp;
 -- Self Join
select e1.id,e1.name as employee_name,e2.name as manager_name from emp as e1
join emp as e2
on e1.manager_id=e2.id;
-- union 
create table emp2(
id int primary key,
name varchar(40),
manager_id int
);
insert into emp2 values
(1,"Haris",2),
(2,"habib",null);
select * from emp2;
  
select * from emp
union
select * from emp2;

-- union all
select * from emp
union all
select * from emp2;
