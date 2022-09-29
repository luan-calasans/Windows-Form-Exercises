using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj37461_Classe;

namespace prj37461_Dll
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
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
                C37461_Classe.peso = double.Parse(txtPeso.Text);
                C37461_Classe.altura = double.Parse(txtAltura.Text);

                C37461_Classe.CalcularIMC();

                if (C37461_Classe.peso != 0 && C37461_Classe.altura != 0)
                {
                    txtResultado.Text = C37461_Classe.exibir;
                }
            }
            catch
            {
                MessageBox.Show("Digite seu peso e altura e clique em calcular!");
                Limpar();
            }
        }

        private void frmIMC_Load(object sender, EventArgs e)
        {
            txtPeso.Focus();
        }

        private void frmIMC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
