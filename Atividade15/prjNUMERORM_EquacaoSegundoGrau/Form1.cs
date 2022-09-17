using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37461_EquacaoSegundoGrau
{
    public partial class frmFormulaBhaskara : Form
    {
        double calculoDelta, valorA, valorB, valorC, calculoX1Positivo, calculoX2Negativo;
        

        public frmFormulaBhaskara()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFormulaBhaskara_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmFormulaBhaskara_Load(object sender, EventArgs e)
        {
            pcbImagem.Image = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                valorA = double.Parse(txtValorA.Text);
                valorB = double.Parse(txtValorB.Text);
                valorC = double.Parse(txtValorC.Text);

                // delta = b² - 4 * a * c
                calculoDelta = Math.Pow(valorB, 2) - 4 * (valorA) * (valorC);

                // x1 = - (b) + raiz(delta);
                calculoX1Positivo = (- (valorB) + Math.Sqrt(calculoDelta)) / (2 * valorA);

                // x2 = - (b) - raiz(delta);
                calculoX2Negativo = (- (valorB) - Math.Sqrt(calculoDelta)) / (2 * valorA);

                if (calculoDelta == 0 && valorA > 0)
                {
                    txtPrimeiroXElevado2.Text = calculoX1Positivo.ToString("0.00") + "²";
                    txtPrimeiroXx1.Text = calculoX1Positivo.ToString("0.00");

                    txtSegundoXElevado2.Text = calculoX2Negativo.ToString("0.00") + "²";
                    txtPrimeiroXx2.Text = calculoX2Negativo.ToString("0.00");

                    txtResultadoDelta.Text = calculoDelta.ToString("0.00");
                    pcbImagem.BackgroundImage = Properties.Resources.D0AMA0;
                }
                else if (calculoDelta == 0 && valorA < 0)
                {
                    txtPrimeiroXElevado2.Text = calculoX1Positivo.ToString("0.00") + "²";
                    txtPrimeiroXx1.Text = calculoX1Positivo.ToString("0.00");

                    txtSegundoXElevado2.Text = calculoX2Negativo.ToString("0.00") + "²";
                    txtPrimeiroXx2.Text = calculoX2Negativo.ToString("0.00");

                    txtResultadoDelta.Text = calculoDelta.ToString("0.00");
                    pcbImagem.BackgroundImage = Properties.Resources.D0AME0;
                }
                else if (calculoDelta > 0 && valorA > 0)
                {
                    txtPrimeiroXElevado2.Text = calculoX1Positivo.ToString("0.00") + "²";
                    txtPrimeiroXx1.Text = calculoX1Positivo.ToString("0.00");

                    txtSegundoXElevado2.Text = calculoX2Negativo.ToString("0.00") + "²";
                    txtPrimeiroXx2.Text = calculoX2Negativo.ToString("0.00");

                    txtResultadoDelta.Text = calculoDelta.ToString("0.00");
                    pcbImagem.BackgroundImage = Properties.Resources.DMA0AMA0;
                }
                else if (calculoDelta > 0 && valorA < 0)
                {
                    txtPrimeiroXElevado2.Text = calculoX1Positivo.ToString("0.00") + "²";
                    txtPrimeiroXx1.Text = calculoX1Positivo.ToString("0.00");

                    txtSegundoXElevado2.Text = calculoX2Negativo.ToString("0.00") + "²";
                    txtPrimeiroXx2.Text = calculoX2Negativo.ToString("0.00");

                    txtResultadoDelta.Text = calculoDelta.ToString("0.00");
                    pcbImagem.BackgroundImage = Properties.Resources.DMA0AME0;
                }
                else if (calculoDelta < 0 && valorA > 0)
                {
                    txtResultadoDelta.Text = calculoDelta.ToString("0.00");
                    pcbImagem.BackgroundImage = Properties.Resources.DME0AMA0;
                }
                else if (calculoDelta < 0 && valorA < 0)
                {
                    txtResultadoDelta.Text = calculoDelta.ToString("0.00");
                    pcbImagem.BackgroundImage = Properties.Resources.DME0AME0;
                }
            }
            catch
            {
                Limpar();
                MessageBox.Show("ERRO! Refaça a conta!");
                txtValorA.Focus();
            }
        }

        private void txtValorB_TextChanged(object sender, EventArgs e)
        {
            if (txtValorB.Text != "")
            {
                txtValorBx1.Text = txtValorB.Text;
                txtValorBx2.Text = txtValorB.Text;
                txtValorBElevado2Delta.Text = txtValorB.Text + "²";
                txtValorBFormulaGrafico.Text = txtValorB.Text;
                txtValorBElevadoFormulaGrafico.Text = txtValorB.Text + "²";
            }
            else
            {
                txtValorBx1.Text = "B";
                txtValorBx2.Text = "B";
                txtValorBElevado2Delta.Text = "B²";
                txtValorBFormulaGrafico.Text = "B";
                txtValorBElevadoFormulaGrafico.Text = "B²";
            }

            if (txtValorA.Text != "" && txtValorB.Text != "" && txtValorC.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtValorC_TextChanged(object sender, EventArgs e)
        {
            if (txtValorC.Text != "")
            {
                txtValorCx1.Text = txtValorC.Text;
                txtValorCx2.Text = txtValorC.Text;
                txtValorCDelta.Text = txtValorC.Text;
                txtValorCFormulaGrafico.Text = txtValorC.Text;
            }
            else
            {
                txtValorCx1.Text = "C";
                txtValorCx2.Text = "C";
                txtValorCDelta.Text = "C";
                txtValorCFormulaGrafico.Text = "C";
            }

            if (txtValorA.Text != "" && txtValorB.Text != "" && txtValorC.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtPrimeiroXElevado2.Text = "X²";
            txtSegundoXElevado2.Text = "X²";
            txtPrimeiroXx1.Text = "X";
            txtPrimeiroXx2.Text = "X";
            txtResultadoDelta.Text = "0";
            txtValorA.Text = "";
            txtValorB.Text = "";
            txtValorC.Text = "";
            txtValorAx1.Text = "A";
            txtValorAx2.Text = "A";
            txtValorADelta.Text = "A";
            txtValorA1FormulaGrafico.Text = "A";
            txtValorA2FormulaGrafico.Text = "A";
            txtValorBx1.Text = "B";
            txtValorBx2.Text = "B";
            txtValorBElevado2Delta.Text = "B²";
            txtValorBFormulaGrafico.Text = "B";
            txtValorBElevadoFormulaGrafico.Text = "B²";
            txtValorCx1.Text = "C";
            txtValorCx2.Text = "C";
            txtValorCDelta.Text = "C";
            txtValorCFormulaGrafico.Text = "C";
            pcbImagem.BackgroundImage = null;
        }

        private void txtValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')
            {
                if (txtValorC.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtValorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')
            {
                if (txtValorC.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')
            {
                if (txtValorC.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtValorA_TextChanged_1(object sender, EventArgs e)
        {
            if (txtValorA.Text != "")
            {
                txtValorAx1.Text = txtValorA.Text;
                txtValorAx2.Text = txtValorA.Text;
                txtValorADelta.Text = txtValorA.Text;
                txtValorA1FormulaGrafico.Text = txtValorA.Text;
                txtValorA2FormulaGrafico.Text = txtValorA.Text;
            }
            else
            {
                txtValorAx1.Text = "A";
                txtValorAx2.Text = "A";
                txtValorADelta.Text = "A";
                txtValorA1FormulaGrafico.Text = "A";
                txtValorA2FormulaGrafico.Text = "A";
            }

            if (txtValorA.Text != "" && txtValorB.Text != "" && txtValorC.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
    }
}
