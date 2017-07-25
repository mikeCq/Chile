CREATE TABLE [dbo].[Table]
(
	[IdPesaje] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FechaPejade] DATE NULL, 
    [Precio] DECIMAL(7, 2) NULL, 
    [CantidadBotes] INT NULL, 
    [SumatoriaBotes] DECIMAL(10, 2) NULL
)
