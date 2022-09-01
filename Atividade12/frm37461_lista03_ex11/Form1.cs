using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm37461_lista03_ex11
{
    public partial class frmVelocidade : Form
    {
        double aceleracao = 0, velocidadeInicial = 0, tempo = 0, mensagem;

        public frmVelocidade()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtAceleracao.Clear();
            txtVelocidadeInicial.Clear();
            txtTempo.Clear();
            txtMensagem.Clear();
            txtAceleracao.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            try
            { 
                if (txtAceleracao.Text != "" && txtVelocidadeInicial.Text != "" && txtTempo.Text != "")
                {
                    aceleracao = double.Parse(txtAceleracao.Text);
                    velocidadeInicial = double.Parse(txtVelocidadeInicial.Text);
                    tempo = double.Parse(txtTempo.Text);

                    //  V = v0 + a. t
                    mensagem = velocidadeInicial + (aceleracao * tempo);

                    if (mensagem <= 40)
                    {
                        txtMensagem.Text = "Veículo muito lento";
                    }
                    else if (mensagem > 40 && mensagem <= 60)
                    {
                        txtMensagem.Text = "Velocidade permitida";
                    }
                    else if (mensagem > 60 && mensagem <= 80)
                    {
                        txtMensagem.Text = "Velocidade de cruzeiro";
                    }
                    else if (mensagem > 80 && mensagem <= 120)
                    {
                        txtMensagem.Text = "Veículo rápido";
                    }
                    else
                    {
                        txtMensagem.Text = "Veículo muito rápido";
                    }
                }
                else
                {
                    MessageBox.Show("Digite nos campos em branco e clique em calcular");
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
