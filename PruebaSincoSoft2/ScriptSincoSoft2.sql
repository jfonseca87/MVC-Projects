use pruebas_multiples

go

create table Usuarios
(
	UsuID int identity(1,1) primary key,
	UsuNombre varchar(50),
	UsuPass varchar(20)
)

go

create table Producto
(
	ID int primary key identity(1,1),
	ProID varchar(5),
	ProDesc varchar(50),
	ProValor money
)

go

create table Pedido
(
	PedID int identity(1,1) primary key,
	PedUsu int,
	PedProd int,
	PedVrUnit Money,
	PedCant float,
	PedSubTot money,
	PedIVA float,
	PedTotal money
	foreign key ("PedUsu") references Usuarios("UsuID") on delete cascade
)



