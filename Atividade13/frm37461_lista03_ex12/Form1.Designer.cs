namespace frm37461_lista03_ex12
{
    partial class frmMediaAluno
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
            this.lblSegundaNota = new System.Windows.Forms.Label();
            this.lblAprovação = new System.Windows.Forms.Label();
            this.txtPrimeiraNota = new System.Windows.Forms.TextBox();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiraNota
            // 
            this.lblPrimeiraNota.AutoSize = true;
            this.lblPrimeiraNota.Location = new System.Drawing.Point(34, 24);
            this.lblPrimeiraNota.Name = "lblPrimeiraNota";
            this.lblPrimeiraNota.Size = new System.Drawing.Size(70, 13);
            this.lblPrimeiraNota.TabIndex = 0;
            this.lblPrimeiraNota.Text = "Primeira Nota";
            // 
            // lblSegundaNota
            // 
            this.lblSegundaNota.AutoSize = true;
            this.lblSegundaNota.Location = new System.Drawing.Point(141, 24);
            this.lblSegundaNota.Name = "lblSegundaNota";
            this.lblSegundaNota.Size = new System.Drawing.Size(76, 13);
            this.lblSegundaNota.TabIndex = 1;
            this.lblSegundaNota.Text = "Segunda Nota";
            // 
            // lblAprovação
            // 
            this.lblAprovação.AutoSize = true;
            this.lblAprovação.Location = new System.Drawing.Point(261, 24);
            this.lblAprovação.Name = "lblAprovação";
            this.lblAprovação.Size = new System.Drawing.Size(49, 13);
            this.lblAprovação.TabIndex = 2;
            this.lblAprovação.Text = "Situação";
            // 
            // txtPrimeiraNota
            // 
            this.txtPrimeiraNota.Location = new System.Drawing.Point(21, 40);
            this.txtPrimeiraNota.Name = "txtPrimeiraNota";
            this.txtPrimeiraNota.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeiraNota.TabIndex = 3;
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Location = new System.Drawing.Point(127, 40);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(100, 20);
            this.txtSegundaNota.TabIndex = 4;
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(233, 40);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(21, 81);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(206, 52);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Média";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(233, 81);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(233, 110);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMediaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(358, 162);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.txtPrimeiraNota);
            this.Controls.Add(this.lblAprovação);
            this.Controls.Add(this.lblSegundaNota);
            this.Controls.Add(this.lblPrimeiraNota);
            this.Name = "frmMediaAluno";
            this.Text = "Média Semestral Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiraNota;
        private System.Windows.Forms.Label lblSegundaNota;
        private System.Windows.Forms.Label lblAprovação;
        private System.Windows.Forms.TextBox txtPrimeiraNota;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

