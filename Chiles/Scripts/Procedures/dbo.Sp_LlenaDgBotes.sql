CREATE PROCEDURE [dbo].[Sp_LlenaDgBotes]
@IdProduccion as int
AS
	SELECT Empleado, fecha, idproduccion 
	from Botes
	where IdProduccion = @IdProduccion
	order by fecha desc