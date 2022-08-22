using FacilAssist.App.View.Services;
using FacilAssist.Core.Business;
using FacilAssist.Core.Entities;
using FacilAssist.Core.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacilAssist.App.View
{
    public partial class frmPesquisaClientes : Form
    {

        private readonly IClienteService _clienteService = new ClienteService();

        public frmPesquisaClientes()
        {
            InitializeComponent();

            // Não gerar linhas automaticas.
            dgvCliente.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            var clienteNegocios = new ClienteNegocios();
            var clienteColecao = clienteNegocios.ConsultarTodos();
            if (clienteColecao.Count > 0)
            {
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = clienteColecao;
                dgvCliente.Update();
                dgvCliente.Refresh();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var clienteNegocios = new ClienteNegocios();

            var clienteColecao = new List<Cliente>();
            bool ehCodigo = int.TryParse(txtPesquisa.Text, out int codigoCliente);

            if (ehCodigo && codigoCliente > 0)
            {
                var clientePesquisa = clienteNegocios.ConsulTarPorCodigo(codigoCliente);

                if (clientePesquisa != null)
                {
                    dgvCliente.DataSource = null;
                    dgvCliente.DataSource = clientePesquisa;
                    dgvCliente.Update();
                    dgvCliente.Refresh();
                }

            }
            else
            {
                clienteColecao = clienteNegocios.ConsulTarPorNome(txtPesquisa.Text);
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = clienteColecao;
                dgvCliente.Update();
                dgvCliente.Refresh();
            }

        }

        private void btnMininizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnFeichar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair ?", "◄ Atenção►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            var cliente = new frmClientes(EModificador.Inserir, null);
            DialogResult dialogResult = new DialogResult();
            dialogResult = cliente.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtualizaGrid();
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verificar se existe dados selecionados.

            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Clinte selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as Cliente);

            var cliente = new frmClientes(EModificador.Alterar, clienteSelecionado);
            var dialogResult = cliente.ShowDialog();
            AtualizaGrid();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Verificar se existe dados selecionados.
            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Clinte selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as Cliente);

            var cliente = new frmClientes(EModificador.Consultar, clienteSelecionado);
            cliente.ShowDialog();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {

            // Verificar se existe dados selecionados.

            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cleinte selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Connfirmar a exclusão.

            DialogResult resultado;

            resultado = MessageBox.Show("Tem certeza que deseja excluir cliente selecionado ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;

            }

            // Pegar cliente selecionado no Datagrid.

            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as Cliente);

            // Intânciar regra de negocios.
            // ClienteNegocios clienteNegocios = new ClienteNegocios();

            // Usar o metodo excluir.
            //var retorno = clienteNegocios.Excluir(clienteSelecionado);

            var retorno = await _clienteService.Excluir(clienteSelecionado.Codigo);

            // Verificar Se excluiu com sucesso

            try
            {
                var codRetorno = Convert.ToInt32(retorno);
                MessageBox.Show(" Cliente excluido com sucerro !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Não foi possivel excluir cliente selecionado. Detalhes: {ex.Message} ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}
