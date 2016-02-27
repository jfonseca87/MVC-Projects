create database Pruebas_Multiples

go

use Pruebas_Multiples

go

create table Person
(
	PersonId int identity(1,1) primary key,
	Forename varchar(15),
	Surname varchar(15),
	Country varchar(20)
)