using FacilAssist.Core.Entities;
using System.Collections.Generic;

namespace FacilAssist.Core.Business
{
    public interface IClienteNegocios
    {
        string Alterar(Cliente cliente);
        List<Cliente> ConsulTarPorCodigo(int codigo);
        List<Cliente> ConsulTarPorNome(string nome);
        List<Cliente> ConsultarTodos();
        string Excluir(Cliente cliente);
        string Inserir(Cliente cliente);
    }
}