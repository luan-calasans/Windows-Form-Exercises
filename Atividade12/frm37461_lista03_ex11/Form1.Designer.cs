namespace frm37461_lista03_ex11
{
    partial class frmVelocidade
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAceleracao = new System.Windows.Forms.Label();
            this.lblVelocidadeInicial = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtAceleracao = new System.Windows.Forms.TextBox();
            this.txtVelocidadeInicial = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAceleracao
            // 
            this.lblAceleracao.AutoSize = true;
            this.lblAceleracao.Location = new System.Drawing.Point(63, 42);
            this.lblAceleracao.Name = "lblAceleracao";
            this.lblAceleracao.Size = new System.Drawing.Size(76, 13);
            this.lblAceleracao.TabIndex = 0;
            this.lblAceleracao.Text = "Aceleração (a)";
            // 
            // lblVelocidadeInicial
            // 
            this.lblVelocidadeInicial.AutoSize = true;
            this.lblVelocidadeInicial.Location = new System.Drawing.Point(202, 42);
            this.lblVelocidadeInicial.Name = "lblVelocidadeInicial";
            this.lblVelocidadeInicial.Size = new System.Drawing.Size(111, 13);
            this.lblVelocidadeInicial.TabIndex = 1;
            this.lblVelocidadeInicial.Text = "Velocidade Inicial (v0)";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(361, 42);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(111, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo de percurso (t)";
            // 
            // txtAceleracao
            // 
            this.txtAceleracao.Location = new System.Drawing.Point(25, 74);
            this.txtAceleracao.Name = "txtAceleracao";
            this.txtAceleracao.Size = new System.Drawing.Size(152, 20);
            this.txtAceleracao.TabIndex = 3;
            // 
            // txtVelocidadeInicial
            // 
            this.txtVelocidadeInicial.Location = new System.Drawing.Point(183, 74);
            this.txtVelocidadeInicial.Name = "txtVelocidadeInicial";
            this.txtVelocidadeInicial.Size = new System.Drawing.Size(152, 20);
            this.txtVelocidadeInicial.TabIndex = 4;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(341, 74);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(152, 20);
            this.txtTempo.TabIndex = 5;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(63, 135);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 6;
            this.lblMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Enabled = false;
            this.txtMensagem.Location = new System.Drawing.Point(25, 169);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(152, 20);
            this.txtMensagem.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(183, 111);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 78);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(341, 111);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 35);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(341, 152);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 37);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmVelocidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 229);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtVelocidadeInicial);
            this.Controls.Add(this.txtAceleracao);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblVelocidadeInicial);
            this.Controls.Add(this.lblAceleracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVelocidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Velocidade Automóvel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAceleracao;
        private System.Windows.Forms.Label lblVelocidadeInicial;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtAceleracao;
        private System.Windows.Forms.TextBox txtVelocidadeInicial;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

