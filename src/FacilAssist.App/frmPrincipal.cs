using Apresentacao.Models;
using Apresentacao.Views;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
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

        private void btnPesquisar_Click(Object sender, EventArgs e)
        {
            frmPesquisaClientes window = new frmPesquisaClientes();
            window.ShowDialog();
        }

        private void btnCadastro_Click(Object sender, EventArgs e)
        {
            frmClientes cliente = new frmClientes(Modificador.Inserir, null);
            DialogResult dialogResult = new DialogResult();
            dialogResult = cliente.ShowDialog();
        }

        private void btnCadastroTeste_Click(Object sender, EventArgs e)
        {
            frmPesquisaClientes window = new frmPesquisaClientes();
            window.ShowDialog();
        }
    }
}
