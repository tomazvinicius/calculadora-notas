using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa1.Formularios
{
    public partial class FormCalcularMedia : Form
    {
        public FormCalcularMedia()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {

            string nome;
            double nota1 = 0;
            double nota2 = 0;
            double media = 0;

            {
                nome = txtNome.Text;
                nota1 = Convert.ToDouble(txtPrimeiraNota.Text);
                nota2 = Convert.ToDouble(txtSegundaNota.Text);
                media = (nota1 + nota2) / 2;
                lbMedia.Text = "Média do acadêmico: " + media.ToString();
                if (media >= 60.0   )
                {
                    lbResultado.Text = nome + " voce foi aprovado(a)";
                }
                else
                {
                    lbResultado.Text = nome + " voce não foi aprovado(a)";
                }




            }
        }

        private void btnNovaSimulacao_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPrimeiraNota.Clear();
            txtSegundaNota.Clear();
            lbResultado.Text = string.Empty;
            lbMedia.Text = string.Empty;
        }
    }
}
