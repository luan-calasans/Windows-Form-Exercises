namespace frm37461_lista03_ex09
{
    partial class frmVerificadorTriangulo
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
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.txtTerceiroValor = new System.Windows.Forms.TextBox();
            this.lblFormador = new System.Windows.Forms.Label();
            this.txtFormadorTriangulo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(37, 32);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(71, 13);
            this.lblPrimeiroValor.TabIndex = 0;
            this.lblPrimeiroValor.Text = "Primeiro Valor";
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Location = new System.Drawing.Point(155, 32);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(77, 13);
            this.lblSegundoValor.TabIndex = 1;
            this.lblSegundoValor.Text = "Segundo Valor";
            // 
            // lblTerceiroValor
            // 
            this.lblTerceiroValor.AutoSize = true;
            this.lblTerceiroValor.Location = new System.Drawing.Point(277, 32);
            this.lblTerceiroValor.Name = "lblTerceiroValor";
            this.lblTerceiroValor.Size = new System.Drawing.Size(73, 13);
            this.lblTerceiroValor.TabIndex = 2;
            this.lblTerceiroValor.Text = "Terceiro Valor";
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(14, 61);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(115, 20);
            this.txtPrimeiroValor.TabIndex = 3;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(135, 61);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(115, 20);
            this.txtSegundoValor.TabIndex = 4;
            // 
            // txtTerceiroValor
            // 
            this.txtTerceiroValor.Location = new System.Drawing.Point(256, 61);
            this.txtTerceiroValor.Name = "txtTerceiroValor";
            this.txtTerceiroValor.Size = new System.Drawing.Size(115, 20);
            this.txtTerceiroValor.TabIndex = 5;
            // 
            // lblFormador
            // 
            this.lblFormador.AutoSize = true;
            this.lblFormador.Location = new System.Drawing.Point(37, 111);
            this.lblFormador.Name = "lblFormador";
            this.lblFormador.Size = new System.Drawing.Size(106, 13);
            this.lblFormador.TabIndex = 6;
            this.lblFormador.Text = "Forma um Triângulo?";
            // 
            // txtFormadorTriangulo
            // 
            this.txtFormadorTriangulo.Enabled = false;
            this.txtFormadorTriangulo.Location = new System.Drawing.Point(14, 135);
            this.txtFormadorTriangulo.Name = "txtFormadorTriangulo";
            this.txtFormadorTriangulo.Size = new System.Drawing.Size(153, 20);
            this.txtFormadorTriangulo.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpar.Location = new System.Drawing.Point(258, 101);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.Location = new System.Drawing.Point(258, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.LightCoral;
            this.btnVerificar.Location = new System.Drawing.Point(175, 101);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(77, 54);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmVerificadorTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtFormadorTriangulo);
            this.Controls.Add(this.lblFormador);
            this.Controls.Add(this.txtTerceiroValor);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.lblTerceiroValor);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVerificadorTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificador de Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroValor;
        private System.Windows.Forms.Label lblSegundoValor;
        private System.Windows.Forms.Label lblTerceiroValor;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.TextBox txtTerceiroValor;
        private System.Windows.Forms.Label lblFormador;
        private System.Windows.Forms.TextBox txtFormadorTriangulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVerificar;
    }
}

