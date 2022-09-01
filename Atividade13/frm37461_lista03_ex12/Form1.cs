using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex12
{
    public partial class frmMediaAluno : Form
    {
        double primeiraNota = 0, segundaNota = 0, media = 0;

        public frmMediaAluno()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtPrimeiraNota.Clear();
            txtSegundaNota.Clear();
            txtMedia.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrimeiraNota.Text != "" || txtSegundaNota.Text != "")
                {
                    // MEDIA = (P1 +  2P2) / 3
                    primeiraNota = double.Parse(txtPrimeiraNota.Text);
                    segundaNota = double.Parse(txtSegundaNota.Text);
                    media = (primeiraNota + (2 * segundaNota)) / 3;

                    if (media >= 5)
                    {
                        txtMedia.Text = $"Aprovado com {media}";
                    }
                    else
                    {
                        txtMedia.Text = $"Reprovado com {media}";
                    }

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
