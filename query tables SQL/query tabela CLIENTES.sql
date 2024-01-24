create table Clientes(
	Id int PRIMARY KEY IDENTITY (1,1),
	Nome varchar (max) not null,
	DataNascimento datetime not null,
	Habilitacao varchar (20) not null,
	Estado varchar (2) not null
)