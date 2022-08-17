# FacilAssist
Sistema básico de gestão de clientes

BANCO DE DADOS
Modelar o banco de dados para gestão de clientes com os seguintes campos:
• Nome
• CPF (único)
• Tipo de cliente (Tabela de domínio com FK na tabela de clientes)
• Sexo
• Situação do cliente (Tabela de domínio com FK na tabela de clientes)

*Todo acesso as tabelas deve ser realizado através de Procedures.

APLICAÇÃO
Regras de negócio:
• Permitir listagem, inclusão, alteração e exclusão de clientes
• Validações e tratamentos de exceção
Definições da aplicação:
• A aplicação deve ser desenvolvida em C# (Asp.net) com banco de dados SQL Server
• A aplicação deve ser estruturada em camadas
• A camada de regra de negócios e acesso a dados deve estar encapsulada em uma API
(WebService ou WCF)
• A aplicação deve acessar a camada de regra de negócios e acesso a dados somente via API
