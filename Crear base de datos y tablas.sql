--DROP database TareaII
--GO
Create database TareaII
GO
Use TareaII
GO
Create table edificiosDisponibles(
	idEdificioDisponible int NOT NULL IDENTITY,
	nombreEdificioDisponible varchar(300),
	PRIMARY KEY (idEdificioDisponible)
);
Create table registroEmpleados(
	idEmpleado int NOT NULL IDENTITY,
	nombreEmpleado varchar(60),
	fechaNacimientoEmpleado varchar(10),
	cedulaEmpleado int,
	contactoEmpleado varchar(8),
	fechaIngresoEmpleado varchar(10),
	edificioQuePerteneceEmpleado varchar(300),
	salarioHoraEmpleado int,
	PRIMARY KEY (idEmpleado)
);
Create table gradosAcademicosDisponibles
(
	idGradoAcademicoDisponible int NOT NULL IDENTITY,
	gradoAcademicoDisponible varchar(20),
	PRIMARY KEY (idGradoAcademicoDisponible)
);
Create table registroProfesion(
	idProfesionDisponible int NOT NULL IDENTITY,
	nombreProfesion varchar(100),
	gradoAcademico varchar(20),
	unidadDeMedidaSalario int,
	PRIMARY KEY (idProfesionDisponible)
);
Create table registroAsociacion(
	idRegistro int NOT NULL IDENTITY,
	idEmpleadoAsociado int,
	idPuestoAsociado int,
	fechaRegistro varchar(10),
	PRIMARY KEY (idRegistro)
);