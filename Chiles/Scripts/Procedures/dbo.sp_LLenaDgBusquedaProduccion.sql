CREATE PROCEDURE [dbo].[sp_LLenaDgBusquedaProduccion]
@fechaini as datetime,
@fechafin as datetime,
@Producto as varchar(20)
AS
if @fechaini = '01/01/2000' and @fechafin = '01/01/2000' and @Producto = ''
	begin
		SELECT IdProduccion,
			   fecha,
			   precio,
			   Producto
		from Produccion

	end