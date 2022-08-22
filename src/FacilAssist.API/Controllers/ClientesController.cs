using FacilAssist.Core.Business;
using FacilAssist.Core.Entities;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FacilAssist.API.Controllers
{

    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Cliente")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ClientesController'
    public class ClientesController : ApiController
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ClientesController'
    {

        private readonly IClienteNegocios _clienteNegocios = new ClienteNegocios();

        /// <summary>
        /// Pesquisar todos clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("BuscarTodos")]
        public IHttpActionResult BuscarTodos()
        {
            try
            {
                var retorno = _clienteNegocios.ConsultarTodos();
                if (retorno.Count == 0)
                {
                    return BadRequest("Clientes não encontrado!");
                }
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Pesquisar cliente por codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsulTarPorCodigo/{codigo:int}")]
        public IHttpActionResult ConsulTarPorCodigo(int codigo)
        {
            try
            {
                var retorno = _clienteNegocios.ConsulTarPorCodigo(codigo);

                if (retorno.Count == 0)
                {
                    return BadRequest("Cliente não encontrado!");
                }
                return Ok(retorno);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        /// <summary>
        /// Adicionar novo cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Adicionar")]
        public IHttpActionResult Adicionar(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(_clienteNegocios.Inserir(cliente));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Atualizar cliente exixtente
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("Atualizar")]
        public IHttpActionResult Atualizar(Cliente cliente)
        {
            try
            {
                _clienteNegocios.Alterar(cliente);
                return Ok(_clienteNegocios.ConsulTarPorCodigo(cliente.Codigo));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Excluir cliente
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("Excluir")]
        public IHttpActionResult Excluir([FromUri] int codigo)
        {
            try
            {
                var clienteExcluir = _clienteNegocios.ConsulTarPorCodigo(codigo).FirstOrDefault();
                if (clienteExcluir.Codigo == 0)
                {
                    return BadRequest("Cliente não encontrado!");
                }
                _clienteNegocios.Excluir(clienteExcluir);
                return Ok("Deletado com Sucesso");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
