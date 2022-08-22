using System;
using System.Windows.Forms;

using RegraNegocios;
using ObjetoTransferencia;
using Apresentacao.Models;

namespace Apresentacao.Views
    {
    public partial class frmClientes : Form
    {
        Modificador telaSelecionada;

        public frmClientes(Modificador modificador, ClienteObjeto cliente)
        {
            InitializeComponent();
               {
                   this.telaSelecionada = modificador;

                if (modificador == Modificador.Alterar)
                {
                    this.lblCliente.Text = "Alterar Cliente";

                    //txtCodigo.Text = cliente.Codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;
                    dtpDataNascimento.Value = cliente.DataNascimento;
                    if (cliente.Sexo == true) // Masculino Principal
                        rdbMasculino.Checked = true;
                    else
                        rdbFeminino.Checked = true;
                    txtTelefone.Text = cliente.Telefone;
                    txtCelular.Text = cliente.Celular;
                    txtEmail.Text = cliente.Email;
                    txtCEP.Text = cliente.CEP;
                    txtEndereco.Text = cliente.Endereco;
                    txtCidade.Text = cliente.Cidade;
                    txtBairro.Text = cliente.Bairro;
                    txtEstado.Text = cliente.Estado;
                    txtComplemento.Text = cliente.Complemento;
                    txtObs.Text = cliente.Obs;
               }


                else if (modificador == Modificador.Consultar)
                {
                    this.lblCliente.Text = "Consultar Cliente";

                    // Carregar campos para tela.

                    //txtCodigo.Text = cliente.Codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;
                    dtpDataNascimento.Value = cliente.DataNascimento;
                    if (cliente.Sexo == true) // Masculino Principal
                        rdbMasculino.Checked = true;
                    else
                        rdbFeminino.Checked = true;
                    txtTelefone.Text = cliente.Telefone;
                    txtCelular.Text = cliente.Celular;
                    txtEmail.Text = cliente.Email;
                    txtCEP.Text = cliente.CEP;
                    txtCidade.Text = cliente.Cidade;
                    txtEndereco.Text = cliente.Endereco;
                    txtBairro.Text = cliente.Bairro;
                    txtEstado.Text = cliente.Estado;
                    txtComplemento.Text = cliente.Complemento;
                    txtObs.Text = cliente.Obs;
                    
                    // Desabilitar campos para somenete leitura.

                    //txtCodigo.Enabled = false;
                    txtNome.Enabled = false;
                    txtCPF.Enabled = false;
                    dtpDataNascimento.Enabled = false;
                    rdbFeminino.Enabled = false;
                    rdbMasculino.Enabled = false;
                    txtTelefone.Enabled = false;
                    txtCelular.Enabled = false;
                    txtCEP.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtEmail.Enabled = false;
                    txtBairro.Enabled = false;
                    txtCidade.Enabled = false;
                    txtEstado.Enabled = false;
                    txtComplemento.Enabled = false;
                    txtObs.Enabled = false;

                    btnSalvar.Visible = false;
                    btnCancelar.Visible = false;
                   


                }


                else if (modificador == Modificador.Inserir)
                {
                    this.lblCliente.Text = " Inserir Cliente";

                    

                }

            }

        }

     private void btnFeichar_Click(object sender, EventArgs e)
        {
            this.Close();

       
        }

        private void btnMininizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          // Verificar se e inserçao ou alteraçao.
            if (telaSelecionada == Modificador.Inserir)
            {
                
                    var clienteObjeto = new ClienteObjeto();

                    var clienteNegocios = new ClienteNegocios();
                    
                     clienteObjeto.Nome = txtNome.Text;
                     clienteObjeto.CPF = txtCPF.Text;
                    clienteObjeto.DataNascimento = dtpDataNascimento.Value;
                    if (rdbMasculino.Checked == true) // Masculino Como Principal
                        clienteObjeto.Sexo = true;
                    else 
                        clienteObjeto.Sexo = false;
                   
                    clienteObjeto.Telefone = txtTelefone.Text;
                    clienteObjeto.Celular = txtCelular.Text;
                    clienteObjeto.Email = txtEmail.Text;
                     clienteObjeto.CEP = txtCEP.Text;
                    clienteObjeto.Endereco = txtEndereco.Text;
                    clienteObjeto.Cidade = txtCidade.Text;
                    clienteObjeto.Bairro = txtBairro.Text;
                    clienteObjeto.Estado = txtEstado.Text;
                     clienteObjeto.Complemento = txtComplemento.Text;
                    clienteObjeto.Obs = txtObs.Text;

                    string retorno = clienteNegocios.Inserir(clienteObjeto);

                    try
                    {
                        int codRetorno = Convert.ToInt32(retorno);

                        MessageBox.Show(" Cliente inserido com sucesso. Código : " + codRetorno.ToString());
                        this.DialogResult = DialogResult.Yes;
                       

                    }
                    catch
                    {
                        MessageBox.Show(" Não foi possivel inserir cliente. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }

            
            
            }
                           
            else if (telaSelecionada == Modificador.Alterar)
            {
                var cliente = new ClienteObjeto();

                //cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
                cliente.Nome = txtNome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                if (rdbMasculino.Checked == true) // Masculino Como Principal
                    cliente.Sexo = true;
                else
                    cliente.Sexo = false;

                cliente.Telefone = txtTelefone.Text;
                cliente.Celular = txtCelular.Text;
                cliente.Email = txtEmail.Text;
                cliente.CEP = txtCEP.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Estado = txtEstado.Text;
                cliente.Complemento = txtComplemento.Text;
                cliente.Obs = txtObs.Text;


                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Alterar(cliente);

                try
                {
                    int codRetorno = Convert.ToInt32(retorno);

                    MessageBox.Show(" Cliente alterado com sucerro. Código : " + codRetorno.ToString());
                    this.DialogResult = DialogResult.Yes;


                }
                catch
                {
                    
                    MessageBox.Show("Não foi possivel alterar cliente. Detalhes : " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            
            }
            else if (telaSelecionada == Modificador.Consultar)
            {
            }


        }
    }
}