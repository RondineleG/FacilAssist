<h3 class="code-line" data-line-start=0 data-line-end=1 ><a id="Banco_de_dados_0"></a>Banco de dados</h3>
<p class="has-line-data" data-line-start="1" data-line-end="7">Modelar o banco de dados para gestão de clientes com os seguintes campos:<br>
• Nome<br>
• CPF (único)<br>
• Tipo de cliente (Tabela de domínio com FK na tabela de clientes)<br>
• Sexo<br>
• Situação do cliente (Tabela de domínio com FK na tabela de clientes)</p>
<p class="has-line-data" data-line-start="8" data-line-end="9">*Todo acesso as tabelas deve ser realizado através de Procedures.</p>
<h3 class="code-line" data-line-start=10 data-line-end=11 ><a id="Aplicao_10"></a>Aplicação</h3>
<p class="has-line-data" data-line-start="11" data-line-end="18">Regras de negócio:<br>
• Permitir listagem, inclusão, alteração e exclusão de clientes<br>
• Validações e tratamentos de exceção Definições da aplicação:<br>
• A aplicação deve ser desenvolvida em C# (<a href="http://Asp.net">Asp.net</a>) com banco de dados SQL Server<br>
• A aplicação deve ser estruturada em camadas<br>
• A camada de regra de negócios e acesso a dados deve estar encapsulada em uma API (WebService ou WCF)<br>
• A aplicação deve acessar a camada de regra de negócios e acesso a dados somente via API</p>
