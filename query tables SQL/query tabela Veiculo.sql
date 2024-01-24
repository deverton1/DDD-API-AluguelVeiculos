create table Veiculo(
	VeiculoId int primary key identity (1,1) not null,
	Placa varchar (7) not null,
	AnoFabricacao int not null,
	TipoVeiculoId int not null,
	Estado char (2) not null,
	MontadoraId int not null,
	Alugado bit null

)