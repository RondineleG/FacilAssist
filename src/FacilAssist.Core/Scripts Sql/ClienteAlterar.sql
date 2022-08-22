USE FacilAssistDB
GO
CREATE PROCEDURE ClienteAlterar
 
 @Codigo INT,
 @Nome VARCHAR (50),
 @CPF VARCHAR (15),
 @Sexo INT,
 @IdPessoaTipo INT ,
 @IdSituacao   INT

  AS

  BEGIN
  
   UPDATE  Cliente
	        
	 SET

 Nome = @Nome, 
 CPF = @CPF,
 Sexo = @Sexo,
 IdPessoaTipo = @IdPessoaTipo,
 IdSituacao = @IdSituacao
 
 WHERE Codigo = @Codigo 

 SELECT @Codigo  AS Retorno

END
