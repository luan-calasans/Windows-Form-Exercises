using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex09
{
    public partial class frmVerificadorTriangulo : Form
    {
        double primeiroValor = 0, segundoValor = 0, terceiroValor = 0;

        public frmVerificadorTriangulo()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {Limpar();
        }

        private void Limpar()
        {
            txtPrimeiroValor.Clear();
            txtSegundoValor.Clear();
            txtTerceiroValor.Clear();
            txtFormadorTriangulo.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            /*
                um de seus lados deve ser maior que o valor absoluto da diferença dos outros dois lados 
                e
                menor que a soma dos outros dois lados
             */

            try
            {
                if (txtPrimeiroValor.Text != "" || txtSegundoValor.Text != "" || txtTerceiroValor.Text != "")
                {
                    primeiroValor = double.Parse(txtPrimeiroValor.Text);
                    segundoValor = double.Parse(txtSegundoValor.Text);
                    terceiroValor = double.Parse(txtTerceiroValor.Text);

                    if (primeiroValor > segundoValor - terceiroValor && primeiroValor < segundoValor + terceiroValor)
                    {
                        txtFormadorTriangulo.Text = "Sim";
                    }
                    else if (segundoValor > primeiroValor - terceiroValor && segundoValor < primeiroValor + terceiroValor)
                    {
                        txtFormadorTriangulo.Text = "Sim";
                    }
                    else if (terceiroValor > primeiroValor - segundoValor && terceiroValor < primeiroValor + segundoValor)
                    {
                        txtFormadorTriangulo.Text = "Sim";
                    }
                    else
                    {
                        txtFormadorTriangulo.Text = "Não";
                    }
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
