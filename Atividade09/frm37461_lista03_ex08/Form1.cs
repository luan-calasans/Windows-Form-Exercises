using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex08
{
    public partial class Form1 : Form
    {
        double primeiroValor = 0, segundoValor = 0, terceiroValor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtClassificacao.Clear();
            txtPrimeiroValor.Clear();
            txtSegundoValor.Clear();
            txtTerceiroValor.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiroValor.Text != "" || txtSegundoValor.Text != "" || txtTerceiroValor.Text != "")
                {
                    primeiroValor = double.Parse(txtPrimeiroValor.Text);
                    segundoValor = double.Parse(txtSegundoValor.Text);
                    terceiroValor = double.Parse(txtTerceiroValor.Text);

                    if (primeiroValor != segundoValor && primeiroValor != terceiroValor)
                    {
                        txtClassificacao.Text = "Triângulo Escaleno ";
                    }
                    else if (primeiroValor == segundoValor && primeiroValor == terceiroValor)
                    {
                        txtClassificacao.Text = "Triângulo Equilátero ";
                    }
                    else
                    {
                        txtClassificacao.Text = "Triângulo Isósceles ";
                    }
                }
                else
                {
                    MessageBox.Show("Digite os três valores para que o triângulo seja classificado");
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
