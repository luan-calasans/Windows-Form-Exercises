using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex07
{
    public partial class frmIMC : Form
    {
        double peso = 0, altura = 0, mensagem;
        public frmIMC()
        {
            InitializeComponent();
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtMensagem.Clear();
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
                else
                {
                    MessageBox.Show("Digite o peso e altura e clique em calcular");
                }
            }
            catch
            {
                txtPeso.Clear();
                txtAltura.Clear();
                txtMensagem.Clear();

                MessageBox.Show("Digite apenas números!");
            }
        }
    }
}
