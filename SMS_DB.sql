create database StudentMS
go
use StudentMS
go

create table Course
(
id int identity primary key,
course varchar(50),
duration int
)

go
create table Batch
(
id int identity primary key,
batch varchar(50),
yr varchar(50)
)

go
create table Registration
(
id int identity primary key,
fname varchar(50),
lname varchar(50),
curse int references Course(id),
batch int references Batch(id),
nic varchar(50),
techno int
)
go

create table Usert
(
id int identity primary key,
fname varchar(50),
lname varchar(50),
uname varchar(50),
pass varchar(50)
)