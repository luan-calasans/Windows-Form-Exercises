using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37461_Completo
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')
            {
                if (txtAltura.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')
            {
                if (txtPeso.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void frmIMC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtResultado.Clear();
            txtPeso.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ClassForms.peso = double.Parse(txtPeso.Text);
                ClassForms.altura = double.Parse(txtAltura.Text);

                ClassForms.CalcularIMC();

                if (ClassForms.peso != 0 && ClassForms.altura != 0)
                {
                    txtResultado.Text = ClassForms.exibir;
                }
            }
            catch
            {
                MessageBox.Show("Digite seu peso e altura e clique em calcular!");
                Limpar();
            }
        }
    }
}
