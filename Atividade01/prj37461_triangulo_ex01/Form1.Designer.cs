namespace prj37461_triangulo_ex01
{
    partial class frmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriangulo));
            this.rctxtLista = new System.Windows.Forms.RichTextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.rdbtnTipoTriangulo = new System.Windows.Forms.RadioButton();
            this.rdbtnAreaTriangulo = new System.Windows.Forms.RadioButton();
            this.cmbEscolha = new System.Windows.Forms.ComboBox();
            this.grpEscolha = new System.Windows.Forms.GroupBox();
            this.grpAreaTriangulo = new System.Windows.Forms.GroupBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.grpTipoTriangulo = new System.Windows.Forms.GroupBox();
            this.txtXTriangulo = new System.Windows.Forms.TextBox();
            this.txtYTriangulo = new System.Windows.Forms.TextBox();
            this.txtZTriangulo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.cbLimparLista = new System.Windows.Forms.CheckBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.grpEscolha.SuspendLayout();
            this.grpAreaTriangulo.SuspendLayout();
            this.grpTipoTriangulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // rctxtLista
            // 
            this.rctxtLista.Location = new System.Drawing.Point(13, 298);
            this.rctxtLista.Name = "rctxtLista";
            this.rctxtLista.Size = new System.Drawing.Size(304, 119);
            this.rctxtLista.TabIndex = 0;
            this.rctxtLista.TabStop = false;
            this.rctxtLista.Text = "";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(34, 31);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(102, 31);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(173, 31);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(14, 13);
            this.lblZ.TabIndex = 4;
            this.lblZ.Text = "Z";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(65, 86);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(90, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo do Triângulo";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(68, 87);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(98, 28);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Altura";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(28, 28);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 6;
            this.lblBase.Text = "Base";
            // 
            // rdbtnTipoTriangulo
            // 
            this.rdbtnTipoTriangulo.AutoSize = true;
            this.rdbtnTipoTriangulo.Location = new System.Drawing.Point(24, 29);
            this.rdbtnTipoTriangulo.Name = "rdbtnTipoTriangulo";
            this.rdbtnTipoTriangulo.Size = new System.Drawing.Size(108, 17);
            this.rdbtnTipoTriangulo.TabIndex = 0;
            this.rdbtnTipoTriangulo.TabStop = true;
            this.rdbtnTipoTriangulo.Text = "Tipo de Triângulo";
            this.rdbtnTipoTriangulo.UseVisualStyleBackColor = true;
            this.rdbtnTipoTriangulo.Click += new System.EventHandler(this.rdbtnTipoTriangulo_Click);
            // 
            // rdbtnAreaTriangulo
            // 
            this.rdbtnAreaTriangulo.AutoSize = true;
            this.rdbtnAreaTriangulo.Location = new System.Drawing.Point(163, 29);
            this.rdbtnAreaTriangulo.Name = "rdbtnAreaTriangulo";
            this.rdbtnAreaTriangulo.Size = new System.Drawing.Size(109, 17);
            this.rdbtnAreaTriangulo.TabIndex = 1;
            this.rdbtnAreaTriangulo.TabStop = true;
            this.rdbtnAreaTriangulo.Text = "Área do Triângulo";
            this.rdbtnAreaTriangulo.UseVisualStyleBackColor = true;
            this.rdbtnAreaTriangulo.Click += new System.EventHandler(this.rdbtnAreaTriangulo_Click);
            // 
            // cmbEscolha
            // 
            this.cmbEscolha.FormattingEnabled = true;
            this.cmbEscolha.Items.AddRange(new object[] {
            "Tipo de Triângulo",
            "Área do Triângulo"});
            this.cmbEscolha.Location = new System.Drawing.Point(299, 25);
            this.cmbEscolha.Name = "cmbEscolha";
            this.cmbEscolha.Size = new System.Drawing.Size(159, 21);
            this.cmbEscolha.TabIndex = 10;
            // 
            // grpEscolha
            // 
            this.grpEscolha.Controls.Add(this.cmbEscolha);
            this.grpEscolha.Controls.Add(this.rdbtnAreaTriangulo);
            this.grpEscolha.Controls.Add(this.rdbtnTipoTriangulo);
            this.grpEscolha.Location = new System.Drawing.Point(13, 13);
            this.grpEscolha.Name = "grpEscolha";
            this.grpEscolha.Size = new System.Drawing.Size(473, 72);
            this.grpEscolha.TabIndex = 9;
            this.grpEscolha.TabStop = false;
            this.grpEscolha.Text = "Escolha";
            // 
            // grpAreaTriangulo
            // 
            this.grpAreaTriangulo.Controls.Add(this.txtArea);
            this.grpAreaTriangulo.Controls.Add(this.txtAltura);
            this.grpAreaTriangulo.Controls.Add(this.txtBase);
            this.grpAreaTriangulo.Controls.Add(this.lblAltura);
            this.grpAreaTriangulo.Controls.Add(this.lblBase);
            this.grpAreaTriangulo.Controls.Add(this.lblArea);
            this.grpAreaTriangulo.Location = new System.Drawing.Point(323, 91);
            this.grpAreaTriangulo.Name = "grpAreaTriangulo";
            this.grpAreaTriangulo.Size = new System.Drawing.Size(163, 138);
            this.grpAreaTriangulo.TabIndex = 10;
            this.grpAreaTriangulo.TabStop = false;
            this.grpAreaTriangulo.Text = "Área do Triângulo";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(12, 48);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(65, 20);
            this.txtBase.TabIndex = 9;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(83, 48);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(65, 20);
            this.txtAltura.TabIndex = 10;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(50, 103);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(65, 20);
            this.txtArea.TabIndex = 11;
            // 
            // grpTipoTriangulo
            // 
            this.grpTipoTriangulo.Controls.Add(this.txtTipo);
            this.grpTipoTriangulo.Controls.Add(this.txtZTriangulo);
            this.grpTipoTriangulo.Controls.Add(this.txtYTriangulo);
            this.grpTipoTriangulo.Controls.Add(this.txtXTriangulo);
            this.grpTipoTriangulo.Controls.Add(this.lblY);
            this.grpTipoTriangulo.Controls.Add(this.lblX);
            this.grpTipoTriangulo.Controls.Add(this.lblZ);
            this.grpTipoTriangulo.Controls.Add(this.lblTipo);
            this.grpTipoTriangulo.Location = new System.Drawing.Point(12, 92);
            this.grpTipoTriangulo.Name = "grpTipoTriangulo";
            this.grpTipoTriangulo.Size = new System.Drawing.Size(223, 137);
            this.grpTipoTriangulo.TabIndex = 11;
            this.grpTipoTriangulo.TabStop = false;
            this.grpTipoTriangulo.Text = "Tipo do Triângulo";
            // 
            // txtXTriangulo
            // 
            this.txtXTriangulo.Location = new System.Drawing.Point(8, 47);
            this.txtXTriangulo.Name = "txtXTriangulo";
            this.txtXTriangulo.Size = new System.Drawing.Size(65, 20);
            this.txtXTriangulo.TabIndex = 12;
            // 
            // txtYTriangulo
            // 
            this.txtYTriangulo.Location = new System.Drawing.Point(78, 47);
            this.txtYTriangulo.Name = "txtYTriangulo";
            this.txtYTriangulo.Size = new System.Drawing.Size(65, 20);
            this.txtYTriangulo.TabIndex = 13;
            // 
            // txtZTriangulo
            // 
            this.txtZTriangulo.Location = new System.Drawing.Point(149, 47);
            this.txtZTriangulo.Name = "txtZTriangulo";
            this.txtZTriangulo.Size = new System.Drawing.Size(65, 20);
            this.txtZTriangulo.TabIndex = 14;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(8, 102);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(206, 20);
            this.txtTipo.TabIndex = 15;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLimparLista
            // 
            this.cbLimparLista.AutoSize = true;
            this.cbLimparLista.Location = new System.Drawing.Point(49, 257);
            this.cbLimparLista.Name = "cbLimparLista";
            this.cbLimparLista.Size = new System.Drawing.Size(129, 17);
            this.cbLimparLista.TabIndex = 15;
            this.cbLimparLista.Text = "Habilitar - Limpar Lista";
            this.cbLimparLista.UseVisualStyleBackColor = true;
            this.cbLimparLista.Click += new System.EventHandler(this.cbLimparLista_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparLista.BackgroundImage = global::prj37461_triangulo_ex01.Properties.Resources.Limpar;
            this.btnLimparLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimparLista.Enabled = false;
            this.btnLimparLista.Location = new System.Drawing.Point(242, 229);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(75, 61);
            this.btnLimparLista.TabIndex = 14;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimparLista.UseVisualStyleBackColor = false;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLixeira.BackgroundImage = global::prj37461_triangulo_ex01.Properties.Resources.Limpar;
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLixeira.Location = new System.Drawing.Point(242, 162);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(75, 61);
            this.btnLixeira.TabIndex = 13;
            this.btnLixeira.Text = "Lixeira";
            this.btnLixeira.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLixeira.UseVisualStyleBackColor = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.BackgroundImage = global::prj37461_triangulo_ex01.Properties.Resources.calcular;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcular.Location = new System.Drawing.Point(242, 95);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 61);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pcbImagem
            // 
            this.pcbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImagem.Location = new System.Drawing.Point(323, 235);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(163, 182);
            this.pcbImagem.TabIndex = 1;
            this.pcbImagem.TabStop = false;
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 428);
            this.Controls.Add(this.cbLimparLista);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpTipoTriangulo);
            this.Controls.Add(this.grpAreaTriangulo);
            this.Controls.Add(this.grpEscolha);
            this.Controls.Add(this.pcbImagem);
            this.Controls.Add(this.rctxtLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome: Luan de Souza Campos Calasans";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTriangulo_FormClosing);
            this.Load += new System.EventHandler(this.frmTriangulo_Load);
            this.grpEscolha.ResumeLayout(false);
            this.grpEscolha.PerformLayout();
            this.grpAreaTriangulo.ResumeLayout(false);
            this.grpAreaTriangulo.PerformLayout();
            this.grpTipoTriangulo.ResumeLayout(false);
            this.grpTipoTriangulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctxtLista;
        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.RadioButton rdbtnTipoTriangulo;
        private System.Windows.Forms.RadioButton rdbtnAreaTriangulo;
        private System.Windows.Forms.ComboBox cmbEscolha;
        private System.Windows.Forms.GroupBox grpEscolha;
        private System.Windows.Forms.GroupBox grpAreaTriangulo;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.GroupBox grpTipoTriangulo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtZTriangulo;
        private System.Windows.Forms.TextBox txtYTriangulo;
        private System.Windows.Forms.TextBox txtXTriangulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.CheckBox cbLimparLista;
    }
}

