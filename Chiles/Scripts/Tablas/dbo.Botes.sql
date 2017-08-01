CREATE TABLE [dbo].[Botes] (
    [IdBotes]      INT      IDENTITY (1, 1) NOT NULL,
    [Empleado]     INT      NULL,
    [Fecha]        DATETIME NULL,
    [IdProduccion] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([IdBotes] ASC),
    CONSTRAINT [fk_Produccion] FOREIGN KEY ([IdProduccion]) REFERENCES [dbo].[Produccion] ([IdProduccion])
);

