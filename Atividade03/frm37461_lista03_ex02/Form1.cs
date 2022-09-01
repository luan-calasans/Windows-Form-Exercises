using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex02
{
    public partial class frmMenorNumero : Form
    {
        double primeiroValor, segundoValor;
        public frmMenorNumero()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroValor.Clear();
            txtSegundoValor.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" && txtSegundoValor.Text != "")
                {
                    primeiroValor = double.Parse(txtPrimeiroValor.Text);
                    segundoValor = double.Parse(txtSegundoValor.Text);

                    if (primeiroValor > segundoValor)
                    {
                        txtResultado.Text = segundoValor.ToString();
                    }
                    else if (segundoValor > primeiroValor)
                    {
                        txtResultado.Text = primeiroValor.ToString();
                    }
                    else
                    {
                        txtResultado.Text = "São iguais";
                    }
                }
                else
                {
                    MessageBox.Show("Digite dois valores para descobrir o menor");
                }
            }
            catch
            {
                MessageBox.Show("Digite apenas números");
            }
        }
    }
    }

