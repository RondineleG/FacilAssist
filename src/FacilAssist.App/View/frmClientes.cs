using FacilAssist.App.View.Services;
using FacilAssist.Core.Business;
using FacilAssist.Core.Entities;
using FacilAssist.Core.Enums;
using System;
using System.Windows.Forms;

namespace FacilAssist.App.View
{
    public partial class frmClientes : Form
    {
        private readonly EModificador telaSelecionada;
        private readonly IClienteNegocios _clienteNegocios = new ClienteNegocios();
        private readonly IClienteService _clienteService = new ClienteService();

        public frmClientes(EModificador modificador, Cliente cliente)
        {
            InitializeComponent();
            {
                telaSelecionada = modificador;

                if (modificador == EModificador.Alterar)
                {
                    lblCliente.Text = "Alterar Cliente";
                    txtCodigo.Text = cliente.Codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;

                    switch (cliente.Sexo)
                    {
                        case ESexo.Masculino:
                            rdbMasculino.Checked = true;
                            break;
                        default:
                            rdbFeminino.Checked = true;
                            break;
                    }

                    switch (cliente.TipoCliente)
                    {
                        case ETipoCliente.PessoFisica:
                            rdbPessoaFisica.Checked = true;
                            break;
                        default:
                            rdbPessoaJuridica.Checked = true;
                            break;
                    }

                    switch (cliente.SituacaoCliente)
                    {
                        case ESituacaoCliente.Ativo:
                            rdbAtivo.Checked = true;
                            break;
                        default:
                            rdbInativo.Checked = true;
                            break;
                    }
                }

                if (modificador == EModificador.Consultar)
                {
                    lblCliente.Text = "Consultar Cliente";

                    // Carregar campos para tela.
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;

                    switch (cliente.Sexo)
                    {
                        case ESexo.Masculino:
                            rdbMasculino.Checked = true;
                            break;
                        default:
                            rdbFeminino.Checked = true;
                            break;
                    }

                    switch (cliente.TipoCliente)
                    {
                        case ETipoCliente.PessoFisica:
                            rdbPessoaFisica.Checked = true;
                            break;
                        default:
                            rdbPessoaJuridica.Checked = true;
                            break;
                    }

                    switch (cliente.SituacaoCliente)
                    {
                        case ESituacaoCliente.Ativo:
                            rdbAtivo.Checked = true;
                            break;
                        default:
                            rdbInativo.Checked = true;
                            break;
                    }

                    // Desabilitar campos para somenete leitura.

                    txtNome.Enabled = false;
                    txtCPF.Enabled = false;
                    rdbFeminino.Enabled = false;
                    rdbMasculino.Enabled = false;
                    rdbPessoaFisica.Enabled = false;
                    rdbPessoaJuridica.Enabled = false;
                    rdbAtivo.Enabled = false;
                    rdbInativo.Enabled = false;

                    btnSalvar.Visible = false;
                    btnCancelar.Visible = false;
                }

                if (modificador == EModificador.Inserir)
                {
                    lblCliente.Text = " Inserir Cliente";
                }

            }

        }

        private void btnFeichar_Click(object sender, EventArgs e) => Close();

        private void btnMininizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verificar se e inserçao ou alteraçao.
            if (telaSelecionada == EModificador.Inserir)
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    CPF = txtCPF.Text,
                    Sexo = rdbMasculino.Checked == true ? ESexo.Masculino : ESexo.Femininio,
                    TipoCliente = rdbPessoaFisica.Checked == true ? ETipoCliente.PessoFisica : ETipoCliente.PessoaJuridica,
                    SituacaoCliente = rdbAtivo.Checked == true ? ESituacaoCliente.Ativo : ESituacaoCliente.Inativo
                };

                var retorno = await _clienteService.Adicionar(cliente);
                var codRetorno = Convert.ToInt32(retorno);

                if (codRetorno == 0)
                {

                    MessageBox.Show(" Cliente inserido com sucesso");
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show(" Não foi possivel inserir cliente. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }

            }

            if (telaSelecionada == EModificador.Alterar)
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    CPF = txtCPF.Text,
                    Sexo = rdbMasculino.Checked == true ? ESexo.Masculino : ESexo.Femininio,
                    TipoCliente = rdbPessoaFisica.Checked == true ? ETipoCliente.PessoFisica : ETipoCliente.PessoaJuridica,
                    SituacaoCliente = rdbAtivo.Checked == true ? ESituacaoCliente.Ativo : ESituacaoCliente.Inativo
                };

                var retorno = _clienteNegocios.Alterar(cliente);

                try
                {
                    var codRetorno = Convert.ToInt32(retorno);
                    MessageBox.Show($"Cliente {cliente.Nome} alterado com sucessoo. Código do cliente :{codRetorno.ToString()}");
                    DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show($"Não foi possivel alterar cliente {cliente.Nome}. Detalhes : {retorno}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }

            }
        }
    }
}