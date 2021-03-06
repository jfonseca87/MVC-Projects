USE [PruebasVarias]
GO
/****** Object:  StoredProcedure [dbo].[TOP5ClientesValor]    Script Date: 08/04/2016 14:45:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TOP5ClientesValor]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TOP(5) Cliente.Cedula, Cliente.Nombres +' '+ Cliente.Apellidos as Nombres, Facturacion.Valor, Sede.Nombre as Sede, Ciudad.Nombre as Ciudad
	FROM Cliente INNER JOIN Sede ON Cliente.IdSede = Sede.IdSede 
	INNER JOIN Facturacion ON Cliente.IdCliente = Facturacion.IdCliente 
	INNER JOIN Ciudad ON Sede.IdCiudad = Ciudad.IdCiudad
	ORDER BY Facturacion.Valor DESC
END
