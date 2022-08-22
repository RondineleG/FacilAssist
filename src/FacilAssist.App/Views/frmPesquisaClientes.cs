using MeuPrimeiroCrud.Data;
using Apresentacao.Models;
using ObjetoTransferencia;
using RegraNegocios;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Apresentacao.Views
{
    public partial class frmPesquisaClientes : Form
    {
        public frmPesquisaClientes()
        {
            this.InitializeComponent();

            // Não gerar linhas automaticas.
            this.dgvCliente.AutoGenerateColumns = false;
        }

        private void AtualizaGrid()
        {
            var verificaNumero = new Regex("[^0-9]");
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            ClienteColecao clienteColecao = new ClienteColecao();
           
            if(verificaNumero.IsMatch(this.txtPesquisa.Text))
            {                
                clienteNegocios.ConsulTarPorCodigo(Convert.ToInt32(txtPesquisa.Text));
            }
            else
            {
                clienteColecao = clienteNegocios.ConsulTarPorNome(txtPesquisa.Text);
            }
           
            

            this.dgvCliente.DataSource = null;
            this.dgvCliente.DataSource = clienteColecao;

            this.dgvCliente.Update();
            this.dgvCliente.Refresh();
        }

        private void btnPesquisar_Click(Object sender, EventArgs e)
        {
            this.AtualizaGrid();

        }

        private void btnMininizar_Click(Object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFeichar_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair ?", "◄ Atenção | CIA3R ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnCadastrar_Click(Object sender, EventArgs e)
        {

            frmClientes cliente = new frmClientes(Modificador.Inserir, null);
            DialogResult dialogResult = new DialogResult();
            dialogResult = cliente.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                this.AtualizaGrid();
            }


        }

        private void btnAlterar_Click(Object sender, EventArgs e)
        {
            // Verificar se existe dados selecionados.

            if (this.dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Clinte selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            ClienteObjeto clienteSelecionado = (this.dgvCliente.SelectedRows[0].DataBoundItem as ClienteObjeto);

            frmClientes cliente = new frmClientes(Modificador.Alterar, clienteSelecionado);
            var dialogResult = cliente.ShowDialog();

            this.AtualizaGrid();


        }

        private void btnConsultar_Click(Object sender, EventArgs e)
        {
            // Verificar se existe dados selecionados.
            if (this.dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Clinte selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            ClienteObjeto clienteSelecionado = (this.dgvCliente.SelectedRows[0].DataBoundItem as ClienteObjeto);

            frmClientes cliente = new frmClientes(Modificador.Consultar, clienteSelecionado);
            cliente.Show();
        }

        private void btnExcluir_Click(Object sender, EventArgs e)
        {

            // Verificar se existe dados selecionados.

            if (this.dgvCliente.SelectedRows.Count == 0)
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

            ClienteObjeto clienteSelecionado = (this.dgvCliente.SelectedRows[0].DataBoundItem as ClienteObjeto);

            // Intânciar regra de negocios.
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            // Usar o metodo excluir.
            String retorno = clienteNegocios.Excluir(clienteSelecionado);

            // Verificar Se excluiu com sucesso

            try
            {
                Int32 codRetorno = Convert.ToInt32(retorno);

                MessageBox.Show(" Cliente excluido com sucerro !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.AtualizaGrid();

            }
            catch
            {
                MessageBox.Show(" Não foi possivel excluir cliente selecionado. Detalhes: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtPesquisa_TextChanged(Object sender, EventArgs e)
        {

        }

        private void frmPesquisaClientes_Load(Object sender, EventArgs e)
        {
            //try
            //{
            //    AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
            //    ClienteColecao clienteColecao = new ClienteColecao();
            //    ClienteObjeto clientes = new ClienteObjeto();
            //    acessoDadosSqlServer.LimparParametros();
            //    acessoDadosSqlServer.AdicionarParametros("@Nome", clientes.Nome);
            //    var dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaPorNome");

            //    foreach (DataRow Linha in dataTableCliente.Rows)
            //    {
            //        ClienteObjeto cliente = new ClienteObjeto
            //        {
            //            Codigo = Convert.ToInt32(Linha["Codigo"]),
            //            Nome = Convert.ToString(Linha["Nome"]),
            //            CPF = Convert.ToString(Linha["CPF"]),
            //            DataNascimento = Convert.ToDateTime(Linha["DataNascimento"]),
            //            Sexo = Convert.ToBoolean(Linha["Sexo"]),
            //            Telefone = Convert.ToString(Linha["Telefone"]),
            //            Celular = Convert.ToString(Linha["Celular"]),
            //            CEP = Convert.ToString(Linha["CEP"]),
            //            Endereco = Convert.ToString(Linha["Endereco"]),
            //            Bairro = Convert.ToString(Linha["Bairro"]),
            //            Cidade = Convert.ToString(Linha["Cidade"]),
            //            Estado = Convert.ToString(Linha["Estado"]),
            //            Complemento = Convert.ToString(Linha["Complemento"]),
            //            Email = Convert.ToString(Linha["Email"]),
            //            Obs = Convert.ToString(Linha["Obs"])
            //        };

            //        clienteColecao.Add(cliente);
            //    }

            //}
            //catch (Exception exception)
            //{
            //    throw new Exception("Não Foi Possive Consultar O Cliente Por Nome. Detalher : " + exception.Message);
            //}
        }
    }
}

