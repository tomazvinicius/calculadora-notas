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
    public partial class FormSituacaoAluno : Form
    {
        public FormSituacaoAluno()
        {
            InitializeComponent();
        }

        private void btAnalisarSituacao_Click(object sender, EventArgs e)
        {
            double mediaFinal = 0;
            double exameFinal = 0;
            double resultado = 0;
            string nome;

            mediaFinal = Convert.ToDouble(txtMediaFinal.Text);
            exameFinal = Convert.ToDouble(txtExameFinal.Text);
            nome = txtNome.Text; 
            resultado = ((6 * mediaFinal) + (4 * exameFinal)) / 10;
            if(resultado >= 50.0)
            {
                lbResultado.Text = nome + ", com a nota: " + resultado.ToString() + " você foi aprovado(a)";
            }
            else
            {
                lbResultado.Text = nome + ", com a nota:" + resultado.ToString() +" infelizmente você não foi aprovado(a)";
            }
            
        }

        private void btnNovaAnalise_Click(object sender, EventArgs e)
        {
            lbResultado.Text = string.Empty;
            txtNome.Clear();
            txtMediaFinal.Clear();
            txtExameFinal.Clear();
        }
    }
}
