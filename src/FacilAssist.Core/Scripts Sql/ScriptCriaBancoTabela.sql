USE FacilAssistDB
GO
CREATE TABLE PessoaTipo
(
    IdPessoaTipo INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
    Descricao VARCHAR (15) NOT  NULL
)
GO
CREATE TABLE Situacao
(
    IdSituacao INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
    Descricao VARCHAR (20) NOT  NULL
)
GO
CREATE TABLE  Cliente
(
 Codigo INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
 Nome VARCHAR (50),
 CPF VARCHAR (15),
 Sexo INT,
 IdPessoaTipo INT FOREIGN KEY  REFERENCES  PessoaTipo (IdPessoaTipo),
 IdSituacao   INT FOREIGN KEY  REFERENCES  Situacao (IdSituacao),
)



