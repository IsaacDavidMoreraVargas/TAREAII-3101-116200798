/****** Script for SelectTopNRows command from SSMS  ******/
Delete FROM TareaII.dbo.registroEmpleados where (idEmpleado>1)
--GO
--Insert into TareaII.dbo.registroEmpleados (nombreEmpleado, fechaNacimientoEmpleado, cedulaEmpleado, contactoEmpleado, fechaIngresoEmpleado, edificioQuePerteneceEmpleado, salarioHoraEmpleado) values ("Isaac","2/26/1995","116200798","72294159","2/26/2023","Ed3","1500");