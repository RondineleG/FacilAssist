using FacilAssist.Core.Data;
using FacilAssist.Core.Entities;
using FacilAssist.Core.Enums;
using System;
using System.Collections.Generic;
using System.Data;

namespace FacilAssist.Core.Business
{
    public class ClienteNegocios : IClienteNegocios
    {
        private readonly AcessoDadosSqlServer _acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Cliente cliente)
        {
            try
            {
                _acessoDadosSqlServer.LimparParametros();
                _acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                _acessoDadosSqlServer.AdicionarParametros("@CPF", cliente.CPF);
                _acessoDadosSqlServer.AdicionarParametros("@Sexo", Convert.ToInt32(cliente.Sexo));
                _acessoDadosSqlServer.AdicionarParametros("@IdPessoaTipo", Convert.ToInt32(cliente.TipoCliente));
                _acessoDadosSqlServer.AdicionarParametros("@IdSituacao", Convert.ToInt32(cliente.SituacaoCliente));

                return _acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteInserir").ToString(); ;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                _acessoDadosSqlServer.LimparParametros();
                _acessoDadosSqlServer.AdicionarParametros("@Codigo", cliente.Codigo);
                _acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                _acessoDadosSqlServer.AdicionarParametros("@CPF", cliente.CPF);
                _acessoDadosSqlServer.AdicionarParametros("@Sexo", Convert.ToInt32(cliente.Sexo));
                _acessoDadosSqlServer.AdicionarParametros("@IdPessoaTipo", Convert.ToInt32(cliente.TipoCliente));
                _acessoDadosSqlServer.AdicionarParametros("@IdSituacao", Convert.ToInt32(cliente.TipoCliente));

                return _acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteAlterar").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                _acessoDadosSqlServer.LimparParametros();
                _acessoDadosSqlServer.AdicionarParametros("@Codigo", cliente.Codigo);

                return _acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteExcluir").ToString();

            }

            catch (Exception exception)
            {
                return exception.Message;

            }

        }

        public List<Cliente> ConsulTarPorNome(string nome)
        {
            try
            {
                var clienteColecao = new List<Cliente>();

                _acessoDadosSqlServer.LimparParametros();
                _acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                var dataTableCliente = _acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaPorNome");

                foreach (DataRow Linha in dataTableCliente.Rows)
                {
                    var cliente = new Cliente
                    {
                        Codigo = Convert.ToInt32(Linha["Codigo"]),
                        Nome = Convert.ToString(Linha["Nome"]),
                        CPF = Convert.ToString(Linha["CPF"]),
                        Sexo = (ESexo)Convert.ToInt32(Linha["Sexo"]),
                        TipoCliente = (ETipoCliente)Convert.ToInt32(Linha["IdPessoaTipo"]),
                        SituacaoCliente = (ESituacaoCliente)Convert.ToInt32(Linha["IdSituacao"]),
                    };

                    clienteColecao.Add(cliente);
                }


                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não Foi Possive Consultar O Cliente Por Nome. Detalher : " + exception.Message);
            }
        }

        public List<Cliente> ConsulTarPorCodigo(int codigo)
        {
            try
            {
                var clienteColecao = new List<Cliente>();

                _acessoDadosSqlServer.LimparParametros();
                _acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                var dataTableCliente = _acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaPorCodigo");
                var cliente = new Cliente();
                foreach (DataRow Linha in dataTableCliente.Rows)
                {
                    cliente.Codigo = Convert.ToInt32(Linha["Codigo"]);
                    cliente.Nome = Convert.ToString(Linha["Nome"]);
                    cliente.CPF = Convert.ToString(Linha["CPF"]);
                    cliente.Sexo = (ESexo)Convert.ToInt32(Linha["Sexo"]);
                    cliente.TipoCliente = (ETipoCliente)Convert.ToInt32(Linha["IdPessoaTipo"]);
                    cliente.SituacaoCliente = (ESituacaoCliente)Convert.ToInt32(Linha["IdSituacao"]);
                }
                clienteColecao.Add(cliente);

                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não Foi Possive Consultar O Cliente Por Codigo. Detalher : " + exception.Message);
            }
        }

        public List<Cliente> ConsultarTodos()
        {
            try
            {
                var clienteColecao = new List<Cliente>();
                var dataTableCliente = _acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaTodos");

                foreach (DataRow Linha in dataTableCliente.Rows)
                {
                    var cliente = new Cliente
                    {
                        Codigo = Convert.ToInt32(Linha["Codigo"]),
                        Nome = Convert.ToString(Linha["Nome"]),
                        CPF = Convert.ToString(Linha["CPF"]),
                        Sexo = (ESexo)Convert.ToInt32(Linha["Sexo"]),
                        TipoCliente = (ETipoCliente)Convert.ToInt32(Linha["IdPessoaTipo"]),
                        SituacaoCliente = (ESituacaoCliente)Convert.ToInt32(Linha["IdSituacao"]),
                    };

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não Foi Possive Consultar O Cliente Por Codigo. Detalher : " + exception.Message);
            }
        }
    }
}
