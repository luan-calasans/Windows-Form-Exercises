using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex04
{
    public partial class frmAreaRetangulo : Form
    {
        double Base, Altura, Resultado;
        public frmAreaRetangulo()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtAltura.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBase.Text != "" && txtAltura.Text != "")
                {
                    Base = double.Parse(txtBase.Text);
                    Altura = double.Parse(txtAltura.Text);

                    Resultado = Base * Altura;

                    if (Resultado >= 100)
                    {
                        txtResultado.Text = "Terreno Grande";
                    }
                    else
                    {
                        txtResultado.Text = "Terreno Pequeno";
                    }
                }
                else
                {
                    MessageBox.Show("Digite dois valores para descobrir a área");
                }
            }
            catch
            {
                MessageBox.Show("Digite apenas números");
            }
        }
    }
}
