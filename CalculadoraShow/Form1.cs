using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraShow
{
    public partial class CalculadoraSimples : Form
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Pegar os números da interface:
            int n1, n2;
            n1 = (int)nudNumero1.Value;
            n2 = (int)nudNumero2.Value;

            //Verificar qual opção está marcada:
            if (rbSoma.Checked)
            {
                txbResultado.Text = (n1 + n2).ToString();
            }
            else if (rbSubtracao.Checked)
            {
                txbResultado.Text = (n1 - n2).ToString();
            }
            else if (rbMultiplicacao.Checked)
            {
                txbResultado.Text = (n1 * n2).ToString();
            }
            else if (rbDivisao.Checked)
            {
                //Verificar se o divisoe é ):
                if (n2 != 0)
                {
                    txbResultado.Text = (n2 / n2).ToString();
                }
                else
                {
                    txbResultado.Text = "ERRO!";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Retornar os nud´s aos valores originais:
            nudNumero1.Value = 0;
            nudNumero2.Value = 0;

            //Retornar os radios para false:
            rbSoma.Checked = false;
            rbSubtracao.Checked = false;
            rbMultiplicacao.Checked = false;
            rbDivisao.Checked = false;

            //Limpar a caixa de resultados:
            txbResultado.Text = "";
            txbResultado.Clear(); // Igual ao de cima. Outra forma de limpar o texto 

        }
    }
}
