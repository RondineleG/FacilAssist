namespace Apresentacao.Views
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.btnFeichar = new System.Windows.Forms.Button();
            this.btnMininizar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.pnlTopo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFeichar
            // 
            this.btnFeichar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeichar.BackColor = System.Drawing.Color.Maroon;
            this.btnFeichar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeichar.ForeColor = System.Drawing.Color.White;
            this.btnFeichar.Location = new System.Drawing.Point(1047, 2);
            this.btnFeichar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFeichar.Name = "btnFeichar";
            this.btnFeichar.Size = new System.Drawing.Size(55, 55);
            this.btnFeichar.TabIndex = 2;
            this.btnFeichar.Text = "X";
            this.btnFeichar.UseVisualStyleBackColor = false;
            this.btnFeichar.Click += new System.EventHandler(this.btnFeichar_Click);
            // 
            // btnMininizar
            // 
            this.btnMininizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMininizar.BackColor = System.Drawing.Color.Maroon;
            this.btnMininizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMininizar.ForeColor = System.Drawing.Color.White;
            this.btnMininizar.Location = new System.Drawing.Point(997, 2);
            this.btnMininizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMininizar.Name = "btnMininizar";
            this.btnMininizar.Size = new System.Drawing.Size(55, 55);
            this.btnMininizar.TabIndex = 1;
            this.btnMininizar.Text = "--";
            this.btnMininizar.UseVisualStyleBackColor = false;
            this.btnMininizar.Click += new System.EventHandler(this.btnMininizar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(22, 13);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 39);
            this.lblCliente.TabIndex = 30;
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlTopo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTopo.Controls.Add(this.lblCliente);
            this.pnlTopo.Controls.Add(this.btnMininizar);
            this.pnlTopo.Controls.Add(this.btnFeichar);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1100, 55);
            this.pnlTopo.TabIndex = 43;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(29, 242);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(186, 29);
            this.dtpDataNascimento.TabIndex = 112;
            this.dtpDataNascimento.Value = new System.DateTime(2015, 2, 26, 0, 0, 0, 0);
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(769, 374);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(6);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(40, 28);
            this.txtEstado.TabIndex = 111;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(177, 541);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 41);
            this.btnCancelar.TabIndex = 110;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(32, 541);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(127, 41);
            this.btnSalvar.TabIndex = 109;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMasculino);
            this.groupBox2.Controls.Add(this.rdbFeminino);
            this.groupBox2.Location = new System.Drawing.Point(245, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(254, 51);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(12, 24);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(6);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(126, 29);
            this.rdbMasculino.TabIndex = 30;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(137, 25);
            this.rdbFeminino.Margin = new System.Windows.Forms.Padding(6);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(117, 29);
            this.rdbFeminino.TabIndex = 31;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(24, 208);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(191, 25);
            this.lblDataNascimento.TabIndex = 107;
            this.lblDataNascimento.Text = "Data De Nascimento";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(545, 280);
            this.Label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(134, 25);
            this.Label11.TabIndex = 106;
            this.Label11.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(550, 308);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(6);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(259, 29);
            this.txtComplemento.TabIndex = 96;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(24, 136);
            this.Label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(60, 25);
            this.Label12.TabIndex = 104;
            this.Label12.Text = "Email";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(545, 220);
            this.Label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(89, 25);
            this.Label10.TabIndex = 103;
            this.Label10.Text = "Telefone";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(545, 139);
            this.Label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(74, 25);
            this.Label13.TabIndex = 105;
            this.Label13.Text = "Celular";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(29, 167);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 30);
            this.txtEmail.TabIndex = 92;
            // 
            // txtCelular
            // 
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.Location = new System.Drawing.Point(550, 167);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Multiline = true;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(259, 32);
            this.txtCelular.TabIndex = 90;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Location = new System.Drawing.Point(550, 246);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefone.MaxLength = 50;
            this.txtTelefone.Multiline = true;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(259, 28);
            this.txtTelefone.TabIndex = 89;
            // 
            // txtCPF
            // 
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Location = new System.Drawing.Point(550, 103);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(6);
            this.txtCPF.MaxLength = 50;
            this.txtCPF.Multiline = true;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(254, 30);
            this.txtCPF.TabIndex = 87;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(545, 72);
            this.Label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 25);
            this.Label9.TabIndex = 102;
            this.Label9.Text = "CPF";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(32, 441);
            this.txtObs.Margin = new System.Windows.Forms.Padding(6);
            this.txtObs.MaxLength = 0;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(777, 67);
            this.txtObs.TabIndex = 99;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(27, 411);
            this.Label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(129, 25);
            this.Label8.TabIndex = 101;
            this.Label8.Text = "Observações";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(29, 308);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(6);
            this.txtCEP.Mask = "#####-###";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(101, 29);
            this.txtCEP.TabIndex = 94;
            this.txtCEP.Text = "13466182";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(736, 343);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(73, 25);
            this.Label5.TabIndex = 91;
            this.Label5.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(368, 373);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(6);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(366, 33);
            this.txtCidade.TabIndex = 98;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(363, 343);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 25);
            this.Label7.TabIndex = 100;
            this.Label7.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(32, 373);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(6);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(295, 33);
            this.txtBairro.TabIndex = 97;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(177, 308);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(322, 29);
            this.txtEndereco.TabIndex = 95;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(29, 103);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.MaxLength = 50;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(500, 30);
            this.txtNome.TabIndex = 85;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(17, 277);
            this.Label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 25);
            this.Label6.TabIndex = 93;
            this.Label6.Text = "CEP";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(27, 343);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 25);
            this.Label4.TabIndex = 88;
            this.Label4.Text = "Bairro";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(172, 277);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 25);
            this.Label3.TabIndex = 86;
            this.Label3.Text = "Endereço";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 72);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 25);
            this.Label2.TabIndex = 84;
            this.Label2.Text = "Nome";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1100, 631);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.pnlTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros De Clientes";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFeichar;
        private System.Windows.Forms.Button btnMininizar;
        internal System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        internal System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        internal System.Windows.Forms.Label lblDataNascimento;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtComplemento;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtCelular;
        internal System.Windows.Forms.TextBox txtTelefone;
        internal System.Windows.Forms.TextBox txtCPF;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtObs;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.MaskedTextBox txtCEP;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCidade;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.TextBox txtNome;
    }
}