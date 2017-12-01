using EscolaDeFormacaoPUC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaDeFormacaoPUC
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FormAlunosInicio form = new FormAlunosInicio();
            //this.Hide();
            form.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormCursosInicio form = new FormCursosInicio();
            form.ShowDialog();
        }

        private void btnFamilias_Click(object sender, EventArgs e)
        {
            FormFamiliasInicio form = new FormFamiliasInicio();
            form.ShowDialog();
        }
    }
}
