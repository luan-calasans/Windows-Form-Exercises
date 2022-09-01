using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex06
{
    public partial class frmMaiorValor : Form
    {
        double primeiroValor = 0, segundoValor = 0, terceiroValor = 0;
        public frmMaiorValor()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroValor.Clear();
            txtSegundoValor.Clear();
            txtTerceiroValor.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" || txtSegundoValor.Text != "" || txtResultado.Text != "")
                {
                    primeiroValor = double.Parse(txtPrimeiroValor.Text);
                    segundoValor = double.Parse(txtSegundoValor.Text);
                    terceiroValor = double.Parse(txtTerceiroValor.Text);

                    if (primeiroValor > segundoValor && primeiroValor > terceiroValor)
                    {
                        txtResultado.Text = primeiroValor.ToString();
                    }
                    else if (segundoValor > primeiroValor && segundoValor > terceiroValor)
                    {
                        txtResultado.Text = segundoValor.ToString();
                    }
                    else if (terceiroValor > primeiroValor && terceiroValor > segundoValor)
                    {
                        txtResultado.Text = terceiroValor.ToString();
                    }
                    else
                    {
                        txtResultado.Text = "Apenas Valores Distintos!";
                    }
                }
                else
                {
                    MessageBox.Show("Digite três valores e clique em 'Descobrir' para achar o maior");
                }
            }
            catch
            {
                MessageBox.Show("Digite apenas números!");
            }
        }
    }
}
