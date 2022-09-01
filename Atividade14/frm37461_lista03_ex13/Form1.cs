using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex13
{
    public partial class frmMediaSemestral : Form
    {
        double primeiraNota = 0, segundaNota = 0, media = 5;

        public frmMediaSemestral()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            txtPrimeiraNota.Clear();
            txtNotaMinimaAprovacao.Clear();
            txtPrimeiraNota.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiraNota.Text != "")
                {
                    // MEDIA = (P1 +  2P2) / 3
                    primeiraNota = double.Parse(txtPrimeiraNota.Text);

                    segundaNota = (3 * media - primeiraNota) / 2.0;

                    media = (primeiraNota + (2 * segundaNota)) / 3;
                    

                    txtNotaMinimaAprovacao.Text = segundaNota.ToString();
                }
                else
                {
                    MessageBox.Show("Digite duas notas e clique em 'Calcular Média'");
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
