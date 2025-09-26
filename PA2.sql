CREATE OR ALTER PROCEDURE spFac_Listar
AS
BEGIN
  SELECT * FROM vw_facturas_simple ORDER BY FechaFacturacion DESC;
END