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
    public partial class FormCalcularExameFinal : Form
    {
        public FormCalcularExameFinal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double media = 0;
            double npex = 0;
            media = Convert.ToDouble(txtMedia.Text);
            npex = (500 - (6 *  media)) / 4;
            lbResultado.Text = "O acadêmico precisa de " + npex.ToString() + " pontos para aprovação!";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtMedia.Clear();
            lbResultado.Text = string.Empty;
        }
    }
}
