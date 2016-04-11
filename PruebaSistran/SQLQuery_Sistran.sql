use PruebasVarias

go

create table Ciudad
(
	IdCiudad int identity(1,1) primary key,
	Nombre varchar(50) not null
)

go

create table Sede
(
	IdSede int identity(1,1) primary key,
	Nombre varchar(50) not null,
	IdCiudad int,
	foreign key (IdCiudad) references Ciudad(IdCiudad) on delete cascade
)

go

create table Cliente
(
	IdCliente int identity(1,1) primary key,
	Cedula varchar(50) not null,
	Nombres varchar(50) not null,
	Apellidos varchar(50) not null,
	IdSede int,
	FechaRegistro datetime,
	foreign key (IdSede) references Sede(IdSede) on delete cascade
)

go

create table Facturacion
(
	IdFactura int identity(1,1) primary key,
	Observaciones varchar(100) not null,
	Item varchar(100) not null,
	Valor money not null,
	IdCliente int,
	FechaRegistro datetime,
	foreign key (IdCliente) references Cliente(IdCliente) on delete cascade
)