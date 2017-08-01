CREATE procedure sp_InsProduccion
@IdProduccion int output,
@Fecha datetime,
@Precio decimal(10,2),
@CantidadBotes int,
@SumaBotes decimal(10,2),
@Producto varchar(20)
as
begin
set nocount on
merge [dbo].[Produccion] as target
using (select @IdProduccion,@Fecha,@Precio,@CantidadBotes,@SumaBotes,@Producto) AS SOURCE (IdProduccion,Fecha,Precio,CantidadBotes,SumaBotes,Producto)
ON (target.IdProduccion = SOURCE.IdProduccion)
WHEN MATCHED THEN
UPDATE SET Fecha = Source.Fecha,
		   Precio = Source.Precio,
		   CantidadBotes = Source.CantidadBotes,
		   SumaBotes = Source.SumaBotes,
		   Producto = source.Producto
WHEN NOT MATCHED THEN
        INSERT (Fecha,Precio,CantidadBotes,SumaBotes,Producto)
        VALUES (Source.Fecha,Source.Precio,Source.CantidadBotes,Source.SumaBotes, source.Producto);
		SET @IdProduccion = SCOPE_IDENTITY()
END
RETURN @IdProduccion