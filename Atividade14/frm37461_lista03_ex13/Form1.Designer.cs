namespace frm37461_lista03_ex13
{
    partial class frmMediaSemestral
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
            this.lblPrimeiraNota = new System.Windows.Forms.Label();
            this.lblNotaMinimaAprovacao = new System.Windows.Forms.Label();
            this.txtPrimeiraNota = new System.Windows.Forms.TextBox();
            this.txtNotaMinimaAprovacao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiraNota
            // 
            this.lblPrimeiraNota.AutoSize = true;
            this.lblPrimeiraNota.Location = new System.Drawing.Point(55, 30);
            this.lblPrimeiraNota.Name = "lblPrimeiraNota";
            this.lblPrimeiraNota.Size = new System.Drawing.Size(92, 13);
            this.lblPrimeiraNota.TabIndex = 0;
            this.lblPrimeiraNota.Text = "Primeira Nota (P1)";
            // 
            // lblNotaMinimaAprovacao
            // 
            this.lblNotaMinimaAprovacao.AutoSize = true;
            this.lblNotaMinimaAprovacao.Location = new System.Drawing.Point(198, 30);
            this.lblNotaMinimaAprovacao.Name = "lblNotaMinimaAprovacao";
            this.lblNotaMinimaAprovacao.Size = new System.Drawing.Size(160, 13);
            this.lblNotaMinimaAprovacao.TabIndex = 2;
            this.lblNotaMinimaAprovacao.Text = "Nota Mínima de Aprovação (P2)";
            // 
            // txtPrimeiraNota
            // 
            this.txtPrimeiraNota.Location = new System.Drawing.Point(23, 57);
            this.txtPrimeiraNota.Name = "txtPrimeiraNota";
            this.txtPrimeiraNota.Size = new System.Drawing.Size(155, 20);
            this.txtPrimeiraNota.TabIndex = 3;
            // 
            // txtNotaMinimaAprovacao
            // 
            this.txtNotaMinimaAprovacao.Location = new System.Drawing.Point(184, 57);
            this.txtNotaMinimaAprovacao.Name = "txtNotaMinimaAprovacao";
            this.txtNotaMinimaAprovacao.Size = new System.Drawing.Size(191, 20);
            this.txtNotaMinimaAprovacao.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(23, 92);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 52);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(184, 92);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(191, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(184, 121);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(191, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMediaSemestral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 168);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNotaMinimaAprovacao);
            this.Controls.Add(this.txtPrimeiraNota);
            this.Controls.Add(this.lblNotaMinimaAprovacao);
            this.Controls.Add(this.lblPrimeiraNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMediaSemestral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média Semestral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiraNota;
        private System.Windows.Forms.Label lblNotaMinimaAprovacao;
        private System.Windows.Forms.TextBox txtPrimeiraNota;
        private System.Windows.Forms.TextBox txtNotaMinimaAprovacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

