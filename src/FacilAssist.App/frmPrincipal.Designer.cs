namespace Apresentacao
{
    partial class frmPrincipal
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnMininizar = new System.Windows.Forms.Button();
            this.btnFeichar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCadastroTeste = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTopo.Size = new System.Drawing.Size(800, 55);
            this.pnlTopo.TabIndex = 44;
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
            // btnMininizar
            // 
            this.btnMininizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMininizar.BackColor = System.Drawing.Color.Maroon;
            this.btnMininizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMininizar.ForeColor = System.Drawing.Color.White;
            this.btnMininizar.Location = new System.Drawing.Point(697, 2);
            this.btnMininizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMininizar.Name = "btnMininizar";
            this.btnMininizar.Size = new System.Drawing.Size(55, 55);
            this.btnMininizar.TabIndex = 1;
            this.btnMininizar.Text = "--";
            this.btnMininizar.UseVisualStyleBackColor = false;
            this.btnMininizar.Click += new System.EventHandler(this.btnMininizar_Click);
            // 
            // btnFeichar
            // 
            this.btnFeichar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeichar.BackColor = System.Drawing.Color.Maroon;
            this.btnFeichar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeichar.ForeColor = System.Drawing.Color.White;
            this.btnFeichar.Location = new System.Drawing.Point(747, 2);
            this.btnFeichar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFeichar.Name = "btnFeichar";
            this.btnFeichar.Size = new System.Drawing.Size(55, 55);
            this.btnFeichar.TabIndex = 2;
            this.btnFeichar.Text = "X";
            this.btnFeichar.UseVisualStyleBackColor = false;
            this.btnFeichar.Click += new System.EventHandler(this.btnFeichar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(58, 133);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(147, 103);
            this.btnPesquisar.TabIndex = 45;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(276, 143);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(147, 103);
            this.btnCadastro.TabIndex = 46;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCadastroTeste
            // 
            this.btnCadastroTeste.Location = new System.Drawing.Point(487, 143);
            this.btnCadastroTeste.Name = "btnCadastroTeste";
            this.btnCadastroTeste.Size = new System.Drawing.Size(147, 103);
            this.btnCadastroTeste.TabIndex = 47;
            this.btnCadastroTeste.Text = "Teste";
            this.btnCadastroTeste.UseVisualStyleBackColor = true;
            this.btnCadastroTeste.Click += new System.EventHandler(this.btnCadastroTeste_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastroTeste);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pnlTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        internal System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnMininizar;
        private System.Windows.Forms.Button btnFeichar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCadastroTeste;
    }
}