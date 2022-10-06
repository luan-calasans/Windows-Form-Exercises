using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37461_Palíndromo
{
    public partial class frm37461_Palíndromo : Form
    {
        string palavra;
        public frm37461_Palíndromo()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cls37461_Palíndromo.comAcentos.Length; i++)
            {
                palavra = txtPalindromo.Text = txtPalindromo.Text.Replace(cls37461_Palíndromo.comAcentos[i].ToString(), cls37461_Palíndromo.semAcentos[i].ToString());
            }

            txtTextoAbaixo.Text = palavra.Replace(",", "").Replace(".", "").Replace(" ", "").ToUpper();

            if (ltbVerificar.Items.Contains(palavra))
            {
                txtTextoAbaixo.Text += cls37461_Palíndromo.palindromoE;
            }
            else
            {
                txtTextoAbaixo.Text += cls37461_Palíndromo.palindromoNE;
            }
        }

        private void ltbVerificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPalindromo.Text = ltbVerificar.SelectedItem.ToString();

            for (int i = 0; i < cls37461_Palíndromo.comAcentos.Length; i++)
            {
                palavra = txtPalindromo.Text = txtPalindromo.Text.Replace(cls37461_Palíndromo.comAcentos[i].ToString(), cls37461_Palíndromo.semAcentos[i].ToString());
            }

            txtTextoAbaixo.Text = palavra.Replace(",", "").Replace(".", "").Replace(" ", "").ToUpper();

            if (ltbVerificar.Items.Contains(palavra))
            {
                txtTextoAbaixo.Text += cls37461_Palíndromo.palindromoE;
            }
            else
            {
                txtTextoAbaixo.Text += cls37461_Palíndromo.palindromoNE;
            }
        }

        private void frm37461_Palíndromo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
