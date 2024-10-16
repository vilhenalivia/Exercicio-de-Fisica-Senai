using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_1
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnVelocidade_Click(object sender, EventArgs e)
        {
            double espaco = Convert.ToDouble(txtEspacoBox.Text);
            double tempo = Convert.ToDouble(txtTempoBox.Text);

            if (txtVelocidadeBox.Text == "")
            {
                double resultado = espaco / tempo;
                lblResposta.Text = resultado.ToString("#0.0");
            }
            else
            {
                lblResposta.Text = "Você já tem a resposta da velocidade.";
            }

        }

        private void btnTempo_Click(object sender, EventArgs e)
        {
            double espaco = Convert.ToDouble(txtEspacoBox.Text);
            double velocidade = Convert.ToDouble(txtVelocidadeBox.Text);

            if (txtTempoBox.Text == "")
            {
                double resultado = espaco / velocidade;
                lblResposta.Text = resultado.ToString("#0.0");
            }
            else
            {
                lblResposta.Text = "Você já tem a resposta do tempo.";
            }
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            double tempo = Convert.ToDouble(txtTempoBox.Text);
            double velocidade = Convert.ToDouble(txtVelocidadeBox.Text);

            if (txtEspacoBox.Text == "")
            {
                double resultado = velocidade * tempo;
                lblResposta.Text = resultado.ToString("#0.0");
            }
            else
            {
                lblResposta.Text = "Você já tem a resposta da Espaço";
            }
        }
    }
}
