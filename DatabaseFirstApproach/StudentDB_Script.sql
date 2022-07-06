create database StudentDB
go

use StudentDb

go

create table Student(
id int primary key identity(1,1),
FirstName varchar(20),
LastName varchar(20),
Age int 
)

go

insert into Student values('James','Thomas',26)

go
select * from student