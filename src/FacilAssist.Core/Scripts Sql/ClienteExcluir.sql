USE FacilAssistDB
GO
CREATE PROCEDURE ClienteExcluir

 @Codigo INT     
AS

BEGIN
 DELETE FROM Cliente
 
 WHERE Codigo = @Codigo 

 SELECT @Codigo  AS Retorno

END
