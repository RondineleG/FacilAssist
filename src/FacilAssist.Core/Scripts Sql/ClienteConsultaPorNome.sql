USE FacilAssistDB
GO
CREATE PROCEDURE ClienteConsultaPorNome
 @Nome VARCHAR (50)  

AS
BEGIN

  
 SELECT * FROM Cliente  WHERE  Nome LIKE '%' + @Nome + '%' 

END

