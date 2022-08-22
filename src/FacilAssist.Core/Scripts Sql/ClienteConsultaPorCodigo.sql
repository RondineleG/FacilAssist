USE FacilAssistDB
GO
CREATE PROCEDURE ClienteConsultaPorCodigo

 @Codigo INT     

AS
BEGIN
  
 SELECT * FROM Cliente WHERE  Codigo = @Codigo 

 SELECT @Codigo  AS Retorno

END