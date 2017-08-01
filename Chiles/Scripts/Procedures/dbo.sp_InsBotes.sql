CREATE procedure sp_InsBotes
@IdBotes int output,
@Empleado Int,
@Fecha datetime,
@IdProduccion int
as
begin
set nocount on
merge [dbo].[Botes] as target
using (select @IdBotes,@Empleado,@Fecha,@IdProduccion) AS SOURCE (IdBotes,Empleado,Fecha,IdProduccion)
ON (target.IdBotes = SOURCE.IdBotes)
WHEN MATCHED THEN
UPDATE SET Empleado = Source.Empleado,
		   Fecha = Source.Fecha,
		   IdProduccion = Source.IdProduccion
		   
WHEN NOT MATCHED THEN
        INSERT (Empleado,Fecha,IdProduccion)
        VALUES (Source.Empleado,Source.Fecha,Source.IdProduccion);
		SET @IdBotes = SCOPE_IDENTITY()
END
RETURN @IdBotes