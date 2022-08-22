using ObjetoTransferencia;
using RegraNegocios;
using System;
using System.Windows.Forms;

namespace Apresentacao.Views
{
    public partial class frmClienteCadastrar : Form
    {
        public frmClienteCadastrar()
        {
            this.InitializeComponent();
        }

        private void btnFeichar_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMininizar_Click(Object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalvar_Click(Object sender, EventArgs e)
        {

            var clienteNegocios = new ClienteNegocios();
            var clienteObjeto = new ClienteObjeto
            {
                Nome = this.txtNome.Text,
                Telefone = this.txtTelefone.Text,
                Email = this.txtEmail.Text,
            };





            String retorno = clienteNegocios.Inserir(clienteObjeto);

            try
            {
                Int32 codRetorno = Convert.ToInt32(retorno);

                MessageBox.Show(" Cliente inserido com sucesso. Código : " + codRetorno.ToString());
                this.DialogResult = DialogResult.Yes;


            }
            catch
            {
                MessageBox.Show(" Não foi possivel inserir cliente. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }



        }
    }
}

