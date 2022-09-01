using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex10
{
    public partial class frmIMC : Form
    {
        double peso = 0, altura = 0, mensagem;

        public frmIMC()
        {
            InitializeComponent();
        }

        private void frmIMC_Load(object sender, EventArgs e)
        {
            txtPeso.Focus();
            cmbGenero.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtMensagem.Clear();
            txtPeso.Focus();
            cmbGenero.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPeso.Text != "" && txtAltura.Text != "")
                {
                    peso = double.Parse(txtPeso.Text);
                    altura = double.Parse(txtAltura.Text);

                    mensagem = peso / (altura * altura);

                    if (cmbGenero.SelectedIndex == 1)
                    {
                        if (mensagem < 20)
                        {
                            txtMensagem.Text = "Abaixo do peso";
                        }
                        else if (mensagem >= 20 && mensagem < 25)
                        {
                            txtMensagem.Text = "Peso ideal";
                        }
                        else
                        {
                            txtMensagem.Text = "Acima do peso";
                        }
                    }
                    else if (cmbGenero.SelectedIndex == 2) {

                        if (mensagem < 19)
                        {
                            txtMensagem.Text = "Abaixo do peso";
                        }
                        else if (mensagem >= 19 && mensagem < 24)
                        {
                            txtMensagem.Text = "Peso ideal";
                        }
                        else
                        {
                            txtMensagem.Text = "Acima do peso";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Digite o peso e altura e clique em calcular");
                }
            }
            catch
            {
                Limpar();
                MessageBox.Show("Digite apenas números!");
            }
        }
    }
}
