namespace frm37461_lista03_ex08
{
    partial class Form1
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
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.lblTerceiroValor = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.txtTerceiroValor = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(48, 31);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(71, 13);
            this.lblPrimeiroValor.TabIndex = 0;
            this.lblPrimeiroValor.Text = "Primeiro Valor";
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSegundoValor.Location = new System.Drawing.Point(48, 95);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(77, 13);
            this.lblSegundoValor.TabIndex = 1;
            this.lblSegundoValor.Text = "Segundo Valor";
            // 
            // lblTerceiroValor
            // 
            this.lblTerceiroValor.AutoSize = true;
            this.lblTerceiroValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTerceiroValor.Location = new System.Drawing.Point(48, 160);
            this.lblTerceiroValor.Name = "lblTerceiroValor";
            this.lblTerceiroValor.Size = new System.Drawing.Size(73, 13);
            this.lblTerceiroValor.TabIndex = 2;
            this.lblTerceiroValor.Text = "Terceiro Valor";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassificacao.Location = new System.Drawing.Point(186, 31);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(131, 13);
            this.lblClassificacao.TabIndex = 3;
            this.lblClassificacao.Text = "Classificação do Triângulo";
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(26, 57);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(121, 20);
            this.txtPrimeiroValor.TabIndex = 4;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(26, 126);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(121, 20);
            this.txtSegundoValor.TabIndex = 5;
            // 
            // txtTerceiroValor
            // 
            this.txtTerceiroValor.Location = new System.Drawing.Point(26, 187);
            this.txtTerceiroValor.Name = "txtTerceiroValor";
            this.txtTerceiroValor.Size = new System.Drawing.Size(121, 20);
            this.txtTerceiroValor.TabIndex = 6;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Enabled = false;
            this.txtClassificacao.Location = new System.Drawing.Point(189, 57);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(121, 20);
            this.txtClassificacao.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(189, 126);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 37);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Khaki;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(189, 169);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 38);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnClassificar
            // 
            this.btnClassificar.BackColor = System.Drawing.Color.Khaki;
            this.btnClassificar.ForeColor = System.Drawing.Color.Black;
            this.btnClassificar.Location = new System.Drawing.Point(189, 83);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(121, 37);
            this.btnClassificar.TabIndex = 10;
            this.btnClassificar.Text = "Classificar";
            this.btnClassificar.UseVisualStyleBackColor = false;
            this.btnClassificar.Click += new System.EventHandler(this.btnClassificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(354, 230);
            this.Controls.Add(this.btnClassificar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.txtTerceiroValor);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.lblTerceiroValor);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroValor;
        private System.Windows.Forms.Label lblSegundoValor;
        private System.Windows.Forms.Label lblTerceiroValor;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.TextBox txtTerceiroValor;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnClassificar;
    }
}

