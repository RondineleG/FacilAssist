USE FacilAssistDB
GO
CREATE PROCEDURE ClienteInserir
 
 @Nome VARCHAR (50),
 @CPF VARCHAR (15),
 @Sexo INT,
 @IdPessoaTipo INT ,
 @IdSituacao   INT
 
   AS

  BEGIN
  
  INSERT INTO Cliente
(
 Nome,
 CPF,
 Sexo,
 IdPessoaTipo ,
 IdSituacao 
)
   VALUES
(
 @Nome,
 @CPF,
 @Sexo,
 @IdPessoaTipo ,
 @IdSituacao 
)
 SELECT @@IDENTITY AS Retorno
END
