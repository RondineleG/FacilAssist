using FacilAssist.Core.Entities;
using System.Threading.Tasks;

namespace FacilAssist.App.View.Services
{
    public interface IClienteService
    {
        Task<string> Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void BuscarPorCodigo(int codProduto);
        void BuscarTodos();
        Task<string> Excluir(int codigo);
    }
}