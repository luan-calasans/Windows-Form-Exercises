using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex01
{
    public partial class frmMaiorValor : Form
    {
        double primeiroValor, segundoValor;
        public frmMaiorValor()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroValor.Clear();
            txtSegundoValor.Clear();
            txtResultado.Clear();
        }

        private void btnMaiorValor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" && txtSegundoValor.Text != "")
                {
                    primeiroValor = double.Parse(txtPrimeiroValor.Text);
                    segundoValor = double.Parse(txtSegundoValor.Text);

                    if (primeiroValor > segundoValor)
                    {
                        txtResultado.Text = primeiroValor.ToString();
                    }
                    else if (segundoValor > primeiroValor)
                    {
                        txtResultado.Text = segundoValor.ToString();
                    }
                    else
                    {
                        txtResultado.Text = "São iguais";
                    }
                }
                else
                {
                    MessageBox.Show("Digite dois valores para descobrir o maior");
                }
            }
            catch
            {
                MessageBox.Show("Digite apenas números");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
