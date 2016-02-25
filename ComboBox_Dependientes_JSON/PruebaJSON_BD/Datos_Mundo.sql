create database Mundo

go

use Mundo

go

create table Continente
(
   id_Continente int primary key identity(1,1),
   Nombre varchar(50) not null
)

go

create table Pais
(
   id_Pais int primary key identity(1,1),
   Nombre varchar(50) not null,
   id_Continente int,
   foreign key ("id_Continente") references Continente("id_Continente") on delete cascade
)

go

insert into Continente (Nombre) values ('Africa');
insert into Continente (Nombre) values ('America');
insert into Continente (Nombre) values ('Asia');
insert into Continente (Nombre) values ('Europa');
insert into Continente (Nombre) values ('Oceania');

go

insert into Pais(Nombre, id_Continente) values ('Colombia', 2);
insert into Pais(Nombre, id_Continente) values ('Estados Unidos', 2);
insert into Pais(Nombre, id_Continente) values ('Simbawe', 1);
insert into Pais(Nombre, id_Continente) values ('Nigeria', 1);
insert into Pais(Nombre, id_Continente) values ('Rusia', 3);
insert into Pais(Nombre, id_Continente) values ('China', 3);
insert into Pais(Nombre, id_Continente) values ('España', 4);
insert into Pais(Nombre, id_Continente) values ('Alemania', 4);
insert into Pais(Nombre, id_Continente) values ('Nueva Zelanda', 5);
insert into Pais(Nombre, id_Continente) values ('Australia', 5);
