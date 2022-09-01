using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37461_triangulo_ex01
{
    public partial class frmTriangulo : Form
    {
        double ValorX = 0, ValorY = 0, ValorZ = 0;
        double Base = 0, Altura = 0, Area;

        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void frmTriangulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmTriangulo_Load(object sender, EventArgs e)
        {
            rdbtnTipoTriangulo.Checked = true;
            cmbEscolha.SelectedIndex = 0;
            grpTipoTriangulo.Enabled = true;
            grpAreaTriangulo.Enabled = false;
            pcbImagem.BackgroundImage = null;
        }

        private void rdbtnTipoTriangulo_Click(object sender, EventArgs e)
        {
            grpTipoTriangulo.Enabled = true;
            grpAreaTriangulo.Enabled = false;
            cmbEscolha.SelectedIndex = 0;
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            rctxtLista.Clear();
        }

        private void rdbtnAreaTriangulo_Click(object sender, EventArgs e)
        {
            grpAreaTriangulo.Enabled = true;
            grpTipoTriangulo.Enabled = false;
            cmbEscolha.SelectedIndex = 1;
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (grpTipoTriangulo.Enabled == true)
            {
                txtXTriangulo.Clear();
                txtYTriangulo.Clear();
                txtZTriangulo.Clear();
                txtTipo.Clear();
            }
            else
            {
                txtBase.Clear();
                txtAltura.Clear();
                txtArea.Clear();
            }
        }

        private void cbLimparLista_Click(object sender, EventArgs e)
        {
            if (cbLimparLista.Text == "Habilitar - Limpar Lista")
            {
                cbLimparLista.Checked = true;
                cbLimparLista.Text = "Desabilitar - Limpar Lista";
                btnLimparLista.Enabled = true;

            }
            else if (cbLimparLista.Text == "Desabilitar - Limpar Lista")
            {
                cbLimparLista.Checked = false;
                cbLimparLista.Text = "Habilitar - Limpar Lista";
                btnLimparLista.Enabled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (grpTipoTriangulo.Enabled == true)
                {
                    if (txtXTriangulo.Text != "" || txtYTriangulo.Text != "" || txtZTriangulo.Text != "")
                    {
                        ValorX = double.Parse(txtXTriangulo.Text);
                        ValorY = double.Parse(txtYTriangulo.Text);
                        ValorZ = double.Parse(txtZTriangulo.Text);

                        if (ValorX + ValorY <= ValorZ || ValorX + ValorZ <= ValorY || ValorY + ValorZ <= ValorX)
                        {
                            txtTipo.Text = "Não forma um triângulo";
                            pcbImagem.BackgroundImage = Properties.Resources.nãotriângulo;
                        }
                        else if (txtXTriangulo != txtYTriangulo && txtXTriangulo != txtZTriangulo)
                        {
                            txtTipo.Text = "Triângulo Escaleno";
                            pcbImagem.BackgroundImage = Properties.Resources.escaleno;

                        }
                        else if (txtXTriangulo == txtYTriangulo && txtXTriangulo == txtZTriangulo)
                        {
                            txtTipo.Text = "Triângulo Equilátero";
                            pcbImagem.BackgroundImage = Properties.Resources.equilátero;
                        }
                        else
                        {
                            txtTipo.Text = "Triângulo Isósceles";
                            pcbImagem.BackgroundImage = Properties.Resources.Isósceles;
                        }


                        if (txtTipo.Text == "Não forma um triângulo")
                        {
                            rctxtLista.Text += $"x = {ValorX} |  y = {ValorY}  |  z = {ValorZ}  |  Não forma um triângulo\n";
                        }
                        else if(txtTipo.Text == "Triângulo Escaleno")
                        {
                            rctxtLista.Text += $"x = {ValorX} |  y = {ValorY}  |  z = {ValorZ}  |  É um Triângulo Escaleno\n";
                        }
                        else if (txtTipo.Text == "Triângulo Equilátero")
                        {
                            rctxtLista.Text += $"x = {ValorX} |  y = {ValorY}  |  z = {ValorZ}  |  É um Triângulo Equilátero\n";
                        }
                        else if (txtTipo.Text == "Triângulo Isósceles")
                        {
                            rctxtLista.Text += $"x = {ValorX} |  y = {ValorY}  |  z = {ValorZ}  |  É um Triângulo Isósceles\n";
                        }
                    }
                }
                else if (grpAreaTriangulo.Enabled == true)
                {
                    Base = double.Parse(txtBase.Text);
                    Altura = double.Parse(txtAltura.Text);
                    Area = (Base * Altura) / 2;
                    txtArea.Text = Area.ToString();

                    rctxtLista.Text += $"base = {Base} |  altura = {Altura}  |  área = {Area} \n";
                    pcbImagem.BackgroundImage = Properties.Resources.Triangulo;
                }
            }
            catch
            {
                MessageBox.Show("Erro nos dados fornecidos!");
            }
        }
    }
}
