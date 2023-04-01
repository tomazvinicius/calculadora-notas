using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeAvaliativa1.Formularios;
namespace AtividadeAvaliativa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            FormCalcularMedia form = new FormCalcularMedia();
            form.ShowDialog();
        }

        private void btnExameFinal_Click(object sender, EventArgs e)
        {
            FormCalcularExameFinal form = new FormCalcularExameFinal();
            form.ShowDialog();
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            FormSituacaoAluno form = new FormSituacaoAluno();
            form.ShowDialog();
        }
    }
}
